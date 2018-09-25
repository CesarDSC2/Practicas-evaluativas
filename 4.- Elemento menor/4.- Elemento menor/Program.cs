using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.__Elemento_menor
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vec = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Ingrese el elemento {0}: ", i + 1);
                vec[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEl elemento menor es: {0}",vec.Min());
            Console.ReadKey();
        }
    }
}
