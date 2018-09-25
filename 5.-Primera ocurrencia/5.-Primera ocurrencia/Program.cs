using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Primera_ocurrencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("¿Cuántos elementos desea ingresar?: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("\n");

            int[] vec = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese el elemento {0}: ", i + 1);
                vec[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El índice del elemento mayor de primera ocurrencia es: {0}", (vec.ToList().IndexOf(vec.Max()) + 1));
            Console.WriteLine("\nPresione cualquier tecla...");
            Console.ReadKey();
        }
    }
}
