using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ejercicio._51
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;
            // Set a variable to the Documents path.
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Append text to an existing file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
            {
                do
                {
                    Console.WriteLine("ingrese una cadena");
                    linea = Console.ReadLine();
                    outputFile.WriteLine(linea);
                } while (linea != "fin");
                
            }
        }
    }
}
