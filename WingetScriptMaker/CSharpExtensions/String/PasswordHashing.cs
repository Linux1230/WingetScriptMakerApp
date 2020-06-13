using System;
using System.Security.Cryptography;
using System.Text;

namespace CSharpExtensions.String
{
    public static class PasswordHashing
    {
        private static string ToNumber(byte[] bytes)
        {
            StringBuilder result = new StringBuilder(bytes.Length * 2);
            for (int i = 0; i < bytes.Length; i++)
                result.Append(bytes[i].ToString());
            return result.ToString();
        }

        public static string HashSHA512(string input)
        {
            byte[] data = Encoding.ASCII.GetBytes(input);
            data = new SHA512Managed().ComputeHash(data);
            string hash = ToNumber(data);
            return hash;
        }

        public static string HashSHA256(string input)
        {
            byte[] data = Encoding.ASCII.GetBytes(input);
            data = new SHA256Managed().ComputeHash(data);
            string hash = ToNumber(data);
            return hash;
        }
    }
}
