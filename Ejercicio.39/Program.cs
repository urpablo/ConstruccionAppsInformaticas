using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._39
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNumero;
            bool flag = false;
            decimal Numero;
            bool RtaFlag = false;
            int i = 0;
            string Rta;
            List<decimal> numeros = new List<decimal>();

            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    strNumero = Console.ReadLine();
                    flag = decimal.TryParse(strNumero, out Numero);

                    if (flag == false)
                    {
                        Console.WriteLine("Debe ingresar un numero");
                    }

                } while (flag == false);

                i = i + 1;
                numeros.Add(Numero);

                Console.WriteLine("Desea seguir agregando Numeros?");
                Rta = Console.ReadLine();

                if (Rta == "No")
                {
                    RtaFlag = true;
                }

            } while (RtaFlag == false);

            foreach (decimal s in numeros)
                Console.WriteLine(s);

            do
            {
                Console.WriteLine(numeros[i-1]);
                i = i - 1;
            } while (i != 0);
            Console.ReadKey();


           
        }
    }
}
