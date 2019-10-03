using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._47
{
    class Program
    {
        static void Main(string[] args)
        {
            string comando;
            var ColaAfiliados = new Queue<string>();
            string caja1 = "LIBRE";
            string caja2 = "LIBRE";
            string caja3 = "LIBRE";

            do
            {
                Console.WriteLine("Ingrese uno de los siguientes comandos: \n" +
                    "afiliado: [nombre]\n" +
                    "caja: [n]\n" +
                    "fin");

                comando= Console.ReadLine().ToUpper();

                if (comando == "FIN")
                {
                    break;
                }
                else if (comando.ToUpper().Contains("AFILIADO:"))
                {
                    ColaAfiliados.Enqueue(comando.Substring(9, comando.Length - 9).Trim());
                    if (caja1 == "LIBRE"&&ColaAfiliados.Count>0)
                    {
                        ColaAfiliados.Dequeue();
                        caja1 = "OCUPADO";
                    }
                    if (caja2 == "LIBRE" && ColaAfiliados.Count > 0)
                    {
                        ColaAfiliados.Dequeue();
                        caja2 = "OCUPADO";
                    }
                    if (caja3 == "LIBRE" && ColaAfiliados.Count > 0)
                    {
                        ColaAfiliados.Dequeue();
                        caja3 = "OCUPADO";
                    }
                }
                else
                {
                    Console.WriteLine("debe ingresar un comando valido");
                }

            } while (comando != "FIN");

            foreach (string number in ColaAfiliados)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(caja1 + "\n" +
                caja2 + "\n" +
                caja3 + "\n");

            Console.ReadKey();


        }
    }
}
