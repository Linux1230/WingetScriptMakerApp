using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingetScriptMaker
{
    public static class ScriptTemplate
    {
        public static readonly string ScriptStopLine = "pause";

        public static List<string> ScriptStartLines(List<string> apps)
        {
            List<string> commands = new List<string>
            {
                $"@echo off",
                $"Echo App list:"
            };
            foreach (var item in apps)
            {
                commands.Add($"Echo {item}");
            }
            return commands;
        }

        public static List<string> ScriptInstallLines(string app)
        {
            return new List<string>
            {
                $"",
                $"winget install {('"' + app + '"')}",
                $"if % ERRORLEVEL % EQU 0",
                $"Echo {app} installed successfully."
            };
        }
    }
}
