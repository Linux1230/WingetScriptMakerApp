using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingetScriptMaker
{
    public static class ScriptCreate
    {
        public static List<string> CreateScript(List<string> apps)
        {
            List<string> script = new List<string>();

            script.AddRange(ScriptTemplate.ScriptStartLines(apps));

            foreach (var item in apps)
            {
                script.AddRange(ScriptTemplate.ScriptInstallLines(item));
            }

            script.Add(ScriptTemplate.ScriptStopLine);

            return script;
        }
    }
}
