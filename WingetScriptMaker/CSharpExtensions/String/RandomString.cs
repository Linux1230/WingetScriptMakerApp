using System;
using System.Linq;

namespace CSharpExtensions.String
{
    public static class RandomString
    {
        //https://stackoverflow.com/questions/1344221/how-can-i-generate-random-alphanumeric-strings
        public static string GetRandomString(int length)
        {
            Random random = new Random();
            const string chars = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
