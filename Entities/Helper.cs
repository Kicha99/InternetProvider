using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InternetProvider.Entities
{

    public static class Helper
    {
        private static string salt = "fhjg129af";

        public static string GetHash(string password) //Получение хэш-значения
        {
            MD5 md5 = new MD5CryptoServiceProvider(); //Экземпляр объекта MD5
            byte[] digest = md5.ComputeHash(Encoding.UTF8.GetBytes(password + salt)); //Вычисление хэш-значения
            string base64digest = Convert.ToBase64String(digest, 0, digest.Length); //Получение строкового значения из массива байт
            return base64digest;
        }
    }

}
