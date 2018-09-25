using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Palíndromo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ban = true;
            do
            {
                Console.Clear();
                try
                {
                    Console.Write("Escriba un  o una palabra 5 dígitos: ");
                    string cad = Console.ReadLine();

                    if (cad.Length > 5)
                        throw new IndexOutOfRangeException("Debe ingresar un valor de 5 dígitos");

                    int sum = 0;
                    char[] elem;
                    char[] auxiliar = new char[cad.Length];
                    elem = cad.ToCharArray();

                    for (int contador = 4; contador >= 0; contador--)
                    {
                        auxiliar[(4 - contador)] = elem[contador];
                    }
                    for (int contador = 0; contador < 3; contador++)
                    {
                        if (auxiliar[contador] == elem[contador])
                        {
                            sum = sum + 1;
                        }

                    }

                    if (sum == 3)
                        Console.WriteLine("Es un palíndromo");
                    else
                        Console.WriteLine("No es un palíndromo");

                    Console.Write("\n¿Desea continuar?\n1.-Si.\n2.-No.\nOpción: ");
                    if (Console.ReadLine() == "1")
                    {
                        ban = true;
                        Console.Clear();
                    }
                    else
                        ban = false;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }

                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (ban);
        }
    }
}
