namespace CSharpExtensions.RunProcess
{
    public class RunProcess
    {
        public static void BatchScript(string filename)
        {
            System.Diagnostics.Process.Start($@"{filename}");
        }
    }
}
