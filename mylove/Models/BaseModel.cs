using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mylove.Models
{
    public class BaseModel
    {
        private Dictionary<string, object> _dict=new Dictionary<string, object>();
        public string sitename = "我的站点Mylove";
        public string owner = "寒冰冷水";
        public Dictionary<string, object> dict { 
            set { _dict = value; }
            get { return _dict; } 
        }
    }
}
