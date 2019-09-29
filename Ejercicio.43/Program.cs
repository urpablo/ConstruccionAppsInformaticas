using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._43
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNumero;
            decimal Numero;
            bool flag = false;
            var ListaNumeros = new List<decimal>();
            bool flagSalida = false;
            decimal suma = 0;
            decimal max = 0;
            decimal min = 0;
            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero o -1 para salir");
                    strNumero = Console.ReadLine();
                    flag = decimal.TryParse(strNumero, out Numero);

                    if (flag == false)
                    {
                        Console.WriteLine("Debe ingresar un numero");
                    }

                } while (flag == false);
                
                if (Numero == -1&&ListaNumeros.Count()==0)
                {
                    return;
                }
                else if(Numero==-1)
                {
                    flagSalida = true;
                }
                else
                {
                    ListaNumeros.Add(Numero);
                }

                
                foreach (decimal s in ListaNumeros)
                {
                    
                    if (s > max)
                    {
                        max = s;
                    }
                }

                min = ListaNumeros[0];
                foreach (decimal s in ListaNumeros)
                {

                    if (s < min)
                    {
                        min = s;
                    }
                }

            } while (flagSalida == false);

            foreach (decimal s in ListaNumeros)
                suma += s;



            //ListaNumeros.Count();

            Console.WriteLine("suma: "+suma);
            Console.WriteLine("promedio: " + (suma/ListaNumeros.Count()));
            Console.WriteLine("maximo: "+max);
            Console.WriteLine("minimo: " + min);

            Console.ReadKey();


        }
    }
}
