using System;
using System.Security.Cryptography;
using System.Text;

namespace MD5Hashgeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string xyz = Console.ReadLine();
                string input = xyz.ToLower().Replace(" ", "");
                MD5 md5Hasher = MD5.Create();
                var hashed = md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
                Console.WriteLine(new Guid(hashed)); ;
                Console.WriteLine("Hello World!");
            }
        }
    }
}
