using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cok_Boyutlu_Diziler_Multidimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Çok Boyutlu Diziler-1
            string[,] regions = new string[5, 3]
            {
                { "istanbul","izmit","balıkesir"},
                  { "ankara","konya","yozgat"},
                  { "antalya","adana","mersin"},
                  { "rize","trabzon","samsun"},
                  { "izmir","mugla","manisa"},
            };
            for (int i = 0; i <=regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("**************************");
            }
            Console.ReadLine();
            //-------------------------------------------------
        }
    }
}
