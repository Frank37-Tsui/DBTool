using DBHelpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTool
{
    public class SqlDefinition
    {
        public static Dictionary<string, string> SqlObjTypeMapping = new Dictionary<string, string>()
        {
            { "FN", "純量值函數" },
            { "TF", "資料表值函數" },
            { "IF", "資料表值函數" },
            { "P", "預存程序" },
            { "U", "資料表" },
            { "V", "檢視表" },
            { "TR", "觸發程序" }
        };

        public static Dictionary<string, string> SqlObjTypeFullName = new Dictionary<string, string>()
        {
            { "FN", "Function" },
            { "TF", "Function" },
            { "IF", "Function" },
            { "P", "Procedure" },
            { "V", "View" },
            { "TR", "Trigger" }
        };

        public static string GetTypeDesc(string type)
        {            
            return SqlObjTypeMapping.ContainsKey(type) ? SqlObjTypeMapping[type] : "";
        }


        public static string GetDefinition(DBConnInfo info, string objName)
        {
            var db = new DBHelper(SqlClientFactory.Instance, info.GetConnectionString());            
            return db.ExecuteScalar<String>("select b.definition from sys.sysobjects a, sys.sql_modules b where a.name = {0} and a.id=b.object_id", objName);
        }

        public static string GetObjType(DBConnInfo info, string objName)
        {
            var db = new DBHelper(SqlClientFactory.Instance, info.GetConnectionString());
            return db.ExecuteScalar<String>("select type from sys.sysobjects where name = {0}", objName).Trim();
        }

        public static string ExportDefinitionToFile(DBConnInfo info, string objName, string file = "")
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                file = $@".\temp\{info.Server}_{info.DBName}_{objName}.sql";                
            }
            var dir = Path.GetDirectoryName(file);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            var definition = GetDefinition(info, objName);
            File.WriteAllText(file, definition);            
            return Path.GetFullPath(file);
        }

        public static string SyncObj(DBConnInfo sour, DBConnInfo trgt, string objName)
        {
            try
            {
                var type = GetObjType(sour, objName);
                if (!SqlObjTypeFullName.ContainsKey(type))
                {
                    return $"該物件類型{type}尚不支援同步功能";
                }

                var typeName = SqlObjTypeFullName[type];
                var sql = $@"if exists(select 1 from sys.sysobjects where name = {{0}}) Drop {typeName} [{objName}];
                EXEC dbo.sp_executesql @statement = {{1}}";
                var db = new DBHelper(SqlClientFactory.Instance, trgt.GetConnectionString());
                db.ExecuteNonQuery(sql, objName, GetDefinition(sour, objName));
                return string.Empty;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
