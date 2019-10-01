using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._44
{
    class Program
    {
        static void Main(string[] args)
        {
            string comando;
            bool flag = false;
            var ListaNombres = new List<string>();

            do
            {
                Console.WriteLine("Ingrese un comando: \n"+
                    "alta [nombre]\n"+
                    "baja [número entero]\n"+
                    "baja [nombre]\n"+
                    "mostrar\n"+
                    "fin\n");
                comando = Console.ReadLine();
                if (comando.ToUpper().Contains("ALTA"))
                {
                    ListaNombres.Add(comando.Substring(4, comando.Length-4).Trim());

                }
                else if (comando.ToUpper()=="FIN")
                {
                    flag = true;
        
                }
                else if (comando.ToUpper() == "MOSTRAR")
                {
                    foreach (string s in ListaNombres)
                        Console.WriteLine(s);
                }
             //   else if ()
              //  {

              //  }
                else
                {
                    Console.WriteLine("Debe ingresar un comando valido");
                }

            } while (flag == false);

            foreach (string s in ListaNombres)
                Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
