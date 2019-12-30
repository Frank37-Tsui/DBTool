using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DBTool
{
    public class DBConnInfo
    {
        public string Id { get; set; }
        public string DBTxt { get; set; }
        public string Server { get; set; }
        public string DBName { get; set; }
        public string LoginId { get; set; }
        public string LoginPw { get; set; }

        public DBConnInfo()
        {
            Id = Guid.NewGuid().ToString();
        }

        [JsonIgnore]
        public string FullName { 
            get
            {
                return $"{DBTxt}-[{Server}].[{DBName}]";
            } 
        }

        public string GetConnectionString() 
        {
            return $"Server={Server};Database={DBName};User Id={LoginId};Password={LoginPw};";
        }
    }

    public class DBConnInfoRepo
    {
        public static DBConnInfoRepo GetInstance()
        {
            return instance;
        }

        private static DBConnInfoRepo instance = new DBConnInfoRepo(@".\config\db.json");
        public string ConfFile { get; }
        private DBConnInfoRepo(string confFile)
        {
            ConfFile = confFile;
        }
        public List<DBConnInfo> Get()
        {
            var json = File.Exists(ConfFile) ? File.ReadAllText(ConfFile) : "[]";
            return JsonConvert.DeserializeObject<List<DBConnInfo>>(json);
        }

        public List<DBConnInfo> Add(DBConnInfo info)
        {
            var infos = Get();
            infos.Add(info);
            return Save(infos);            
        }

        public List<DBConnInfo> Save(List<DBConnInfo> infos)
        {
            var dir = Path.GetDirectoryName(ConfFile);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            File.WriteAllText(ConfFile, JsonConvert.SerializeObject(infos, Formatting.Indented));
            return infos;
        }

        public List<DBConnInfo> Update(DBConnInfo info)
        {
            var infos = Get();
            infos[infos.FindIndex(x => x.Id == info.Id)] = info;            
            return Save(infos);
        }

        public List<DBConnInfo> Delete(DBConnInfo info)
        {
            var infos = Get();
            infos.RemoveAll(x => x.Id == info.Id);
            Save(infos);            
            return infos;
        }
    }
}
