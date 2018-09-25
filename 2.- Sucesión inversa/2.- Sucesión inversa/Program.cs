using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.__Sucesión_inversa
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
            Console.WriteLine();
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine("Elemento {0}: {1}", i + 1, vec[i]);
            }
            Console.WriteLine("Pulse cualquier tecla para salir...");
            Console.ReadLine();
        }
    }
}
