using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBTool
{
    public class SqlObject
    {
        public string Name { get; set; }
        public DateTime CrDate { get; set; }
        public string Type { get; set; }
        public string Definition { get; set; }
        public string TypeDesc { 
            get 
            {
                return SqlDefinition.GetTypeDesc(Type.Trim());
            } 
        }
        public string TypeFullName
        {
            get
            {
                return SqlDefinition.GetTypeFullName(Type.Trim());
            }
        }
    }
}
