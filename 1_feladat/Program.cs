using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 20; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            int szam = 30;
            while (szam<=40)
            {
                Console.Write(szam + ",");
                szam++;
            }

            Console.WriteLine();
            int num = 40;
            do
            {
                Console.Write(num + "|");
                num++;

            } while (num!=51);


            Console.ReadKey();
        }
    }
}
