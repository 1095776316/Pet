using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Pet.Core.Helper.Secrets
{
    public static class MD5Helper
    {
        /// <summary>
        /// 16位MD5加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string MD5Encrypt(string password, string securityStamp)
        {
            return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(password + securityStamp))).Replace("-", "");
        }

    }
}
