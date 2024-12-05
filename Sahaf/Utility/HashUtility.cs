using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.Utility
{
    internal class HashUtility
    {
        public static string MdFive(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] sonuc = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            string strHashedData = "";
            foreach (byte b in sonuc)
            {
                strHashedData += b.ToString("x2");
            }
            return strHashedData;
        }
        public static bool MdFiveSifreKontrol(string password, string hashedvalue)
        {
            return MdFive(password) == hashedvalue ? true : false;
        }
    }
}
