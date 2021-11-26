using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public static class Helper
    {
        public static byte[] Hash(string plaintext)
        {
            HashAlgorithm algorithm = HashAlgorithm.Create("MD5");
            return algorithm.ComputeHash(ASCIIEncoding.ASCII.GetBytes(plaintext));
        }
        public static string RandomString(int len)
        {
            string a = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                sb.Append(a[random.Next(a.Length)]);
            }
            return sb.ToString();
        }
    }
}
