using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_y_menor
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, may = 0, men = 0;
            Console.Write("¿Cuantos números desea ingresar?: ");
            x = int.Parse(Console.ReadLine());
            int[] n = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.Write("Ingrese el elemento {0}: ", i + 1);
                n[i] = int.Parse(Console.ReadLine());
            }

            may = n[0];
            men = n[0];
            for (int i = 0; i < x; i++)
            {
                if (n[i] > may)
                {
                    may = n[i];
                }
                else if (n[i] < men)
                {
                    men = n[i];
                }
            }
            Console.WriteLine("\nEl mayor de los elementos es: {0}", may);
            Console.WriteLine("El menor de los elementos es: {0}", men);
            Console.Write("\nPresione cualquier tecla...");
            Console.ReadLine();
        }
    }
}
