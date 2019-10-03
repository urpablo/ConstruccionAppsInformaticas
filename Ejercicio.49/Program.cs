using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio._49
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Pablo\Desktop\MyTest.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hola Mundo");
                    //sw.WriteLine("And");
                    //sw.WriteLine("Welcome");
                }
            }
            else
            {
                Console.WriteLine("ya existe el archivo ameo");
                Console.ReadKey();
            }

        }
    }
}
