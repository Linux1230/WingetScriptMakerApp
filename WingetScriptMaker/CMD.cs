using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace WingetScriptMaker
{
    public static class CMD
    {
        public static List<string> WingetSearch()
        {
            List<string> apps = new List<string>();
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C winget search > appList.temp",
                    RedirectStandardOutput = true,
                    UseShellExecute = false
                }
            };
            process.Start();
            process.WaitForExit();

            apps.AddRange(IO.ReadAndDeleteFile("appList.temp"));
            
            int maxAppNameLenght = 0;
            for (int i = 0; i < apps[1].Length - 1; i++)
            {
                if (apps[1][i] == 'I' && apps[1][i + 1] == 'd')
                    break;
                else
                    maxAppNameLenght++;
            }

            for (int i = 0; i < 3; i++)
            {
                apps.RemoveAt(0);
            }

            for (int i = 0; i < apps.Count(); i++) 
            {
                apps[i] = apps[i].Substring(0, maxAppNameLenght);
                apps[i] = apps[i].Trim();
            }
            
            return apps;
        }

        public static void WingetRunScript(string filename)
        {
            Process.Start($@"{filename}");
        }

        public static void WingetInstall(string app)
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Normal,
                    FileName = "cmd.exe",
                    Arguments = $"/C winget install {'"' + app + '"'}",
                    UseShellExecute = false
                }
            };
            process.Start();
            process.WaitForExit();
        }
    }
}