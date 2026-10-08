using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Alsó határ: ");
            int also = int.Parse(Console.ReadLine());

            Console.Write("Felső határ: ");
            int felso = int.Parse(Console.ReadLine());


            for (int i = also; i <= felso; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
