using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CSharpExtensions.IO
{
    public static class IO
    {
        public static List<string> ReadFile(string name)
        {
            return File.ReadAllLines(name).ToList();
        }

        public static void WriteFile(string name, List<string> file)
        {
            File.WriteAllLines(name, file);
        }

        public static void DeleteFile(string name)
        {
            File.Delete(name);
        }

        public static List<string> ReadAndDeleteFile(string name)
        {
            List<string> temp = ReadFile(name);
            DeleteFile(name);
            return temp;
        }

        public static List<string> GetFileNamesFromFolder(string path)
        {
            int skipDirectory = path.Length;
            if (!path.EndsWith("" + Path.DirectorySeparatorChar)) skipDirectory++;

            return Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories)
                            .Select(f => f.Substring(skipDirectory)).ToList<string>();
        }

        public static string GetExePath()
        {
            return Application.StartupPath;
        }
    }
}
