using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._38
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNumero;
            bool flagNum = false;
            decimal Numero;
            bool flagRta = false;
            string Rta;
            string acumulador="0";

            do
            {
                Console.WriteLine("Ingrese un numero");
                strNumero = Console.ReadLine();
                flagNum = decimal.TryParse(strNumero, out Numero);

                if (flagNum == false)
                {
                    Console.WriteLine("debe ingresar un numero");
                }
                else
                {
                    acumulador = acumulador + Numero;
                }



            } while (Rta == "Si");

        }
    }
}
