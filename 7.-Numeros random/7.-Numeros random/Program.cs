using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Numeros_random
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("¿Cuántos números desea obtener de manera aleatoria? (1-100): ");
            n = int.Parse(Console.ReadLine());
            Random num = new Random();
            int[] vec = new int[n];
            Console.WriteLine("Números generados aleatoriamente: ");
            for (int i = 0; i < n; i++)
            {
                int random = num.Next(1, 100);
                vec[i] = random;
                Console.WriteLine(random);
            }
            Array.Sort(vec);
            Console.WriteLine("\nLista ordenada de menor a mayor: ");
            for (int contador = 0; contador < n; contador++)
            {
                Console.WriteLine(vec[contador]);
            }
            Console.ReadKey();
        }
    }
}
