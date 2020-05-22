using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingetScriptMaker
{
    public static class Script
    {
        public static void Create(List<string> apps, string filename)
        {
            List<string> script = new List<string>();

            script.AddRange(ScriptTemplate.ScriptStartLines(apps));

            foreach (var item in apps)
            {
                script.AddRange(ScriptTemplate.ScriptInstallLines(item));
            }

            script.Add(ScriptTemplate.ScriptStopLine);

            IO.WriteFile(filename, script);
        }

        public static List<string> Load(string filename)
        {
            return IO.ReadFile(filename);
        }
    }
}
