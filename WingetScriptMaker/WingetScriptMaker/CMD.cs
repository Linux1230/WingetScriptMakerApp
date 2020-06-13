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
        public static List<AppEntity> WingetSearch()
        {
            List<string> commandOutput = new List<string>();
            List<AppEntity> apps = new List<AppEntity>();

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

            commandOutput.AddRange(IO.ReadAndDeleteFile("appList.temp"));

            #region AppName
            int maxAppNameLenght = 0;
            for (int i = maxAppNameLenght; i < commandOutput[1].Length - 1; i++)
            {
                if (commandOutput[1][i] == 'I' && commandOutput[1][i + 1] == 'd')
                    break;
                else
                    maxAppNameLenght++;
            }
            #endregion

            #region AppId
            int maxAppIdLenght = 0;
            for (int i = maxAppNameLenght; i < commandOutput[1].Length - 1; i++)
            {
                if (commandOutput[1][i] == 'V' && commandOutput[1][i + 1] == 'e')
                    break;
                else
                    maxAppIdLenght++;
            }
            #endregion

            for (int i = 0; i < 3; i++)
            {
                commandOutput.RemoveAt(0);
            }

            for (int i = 0; i < commandOutput.Count(); i++)
            {
                int maxAppVersionLenght = commandOutput[i].Length - (maxAppNameLenght + maxAppIdLenght);
                apps.Add(new AppEntity(
                                commandOutput[i].Substring(0, maxAppNameLenght).Trim(),
                                commandOutput[i].Substring(maxAppNameLenght, maxAppIdLenght).Trim(),
                                commandOutput[i].Substring(maxAppNameLenght + maxAppIdLenght, maxAppVersionLenght).Trim()
                         ));
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