using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpExtensions.IO;

namespace WingetScriptMaker
{
    public static class WingetScript
    {
        public static void Create(List<string> apps, string filename)
        {
            List<string> script = new List<string>();

            script.AddRange(WingetScriptTemplate.ScriptStartLines(apps));

            foreach (var item in apps)
            {
                script.AddRange(WingetScriptTemplate.ScriptInstallLines(item));
            }

            script.Add(WingetScriptTemplate.ScriptStopLine);

            IO.WriteFile(filename, script);
        }

        public static List<string> Load(string filename)
        {
            return IO.ReadFile(filename);
        }
    }
}
