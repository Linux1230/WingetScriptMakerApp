using System;

namespace CSharpExtensions.String
{
    //https://codeexamples.dev/csharp-string-contains-insensitive/
    public static class Contains
    {
        public static bool ContainsCaseInsensitive(this string text, string value,
            StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
        {
            return text.IndexOf(value, stringComparison) >= 0;
        }
    }
}
