using System;

namespace CSharp.Extension
{
    //https://codeexamples.dev/csharp-string-contains-insensitive/
    public static class Extension
    {
        public static bool ContainsCaseInsensitive(this string text, string value,
            StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }
    }
}
