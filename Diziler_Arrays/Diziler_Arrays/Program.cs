using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diziler kullanım şekli -1
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "omer";
            ogrenciler[1] = "ahmet";
            ogrenciler[2] = "mert";
            foreach (var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }
            //-----------------------------
            // Diziler kullanım şekli -2
            string[] ogrenciler2 = { "omer","mert","ahmet" };
            foreach (var ogrenci2 in ogrenciler2)
            {
                Console.WriteLine(ogrenci2);
            }
            //-----------------------------
            // Diziler kullanım şekli -3
            string[] ogrenciler3 =new [] { "omer","mert","ahmet" };
            foreach (var ogrenci3 in ogrenciler3)
            {
                Console.WriteLine(ogrenci3);
            }
            Console.ReadLine();
            //-----------------------------
        }
    }
}
