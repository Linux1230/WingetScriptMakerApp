using System;
using System.Security.Cryptography;
using System.Text;

namespace CSharpExtensions.String
{
    public static class PasswordHashing
    {
        private static string ToHexDec(byte[] bytes)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
                result.Append(bytes[i].ToString("x2"));
            return result.ToString();
        }

        public static string HashSHA512(string input)
        {
            using (SHA512 _SHA512 = SHA512.Create())
            {
                byte[] data = Encoding.UTF8.GetBytes(input);
                data = _SHA512.ComputeHash(data);
                return ToHexDec(data);
            }
        }

        public static string HashSHA256(string input)
        {
            using (SHA256 _SHA256 = SHA256.Create())
            {
                byte[] data = Encoding.UTF8.GetBytes(input);
                data = _SHA256.ComputeHash(data);
                return ToHexDec(data);
            }
        }

        public static string HashMD5(string input)
        {
            using (MD5 _MD5 = MD5.Create())
            {
                byte[] data = Encoding.UTF8.GetBytes(input);
                data = _MD5.ComputeHash(data);
                return ToHexDec(data);
            }
        }
    }
}
