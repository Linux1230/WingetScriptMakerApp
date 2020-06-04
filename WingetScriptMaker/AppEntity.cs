using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingetScriptMaker
{
    public class AppEntity
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Version { get; set; }

        public AppEntity(){}

        public AppEntity(string name, string id, string version)
        {
            Name = name;
            Id = id;
            Version = version;
        }
    }
}
