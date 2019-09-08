using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su texto o presione del para salir.");
            Boolean flag = true;


            do
            {
                ConsoleKeyInfo keyinfo;
                String texto;
                keyinfo = Console.ReadKey();
                texto = Console.ReadLine();

                if (keyinfo.Key == ConsoleKey.Delete)
                {
                    break;
                }

                Console.WriteLine("El texto introducido es: " + texto);
                flag = true;

                //keyinfo = Console.ReadKey();
                //Console.WriteLine(keyinfo.Key + " was pressed");
            } while (flag == true);
            

        }
    }
}
