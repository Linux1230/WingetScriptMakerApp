using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            
                bool stop = false;
                for (int j = maxAppNameLenght - 1; j > 0; j--)
                {
                    stop = (apps[i][j] != ' ');

                    if (apps[i][j] == ' ' && !stop)
                        apps[i] = apps[i].Remove(j);
                    else
                        break;
                }
            }
            
            return apps;
        }
    }
}