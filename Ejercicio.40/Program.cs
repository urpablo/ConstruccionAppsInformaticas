using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            string phrase = Console.ReadLine();
            string[] words = phrase.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }
            Console.ReadKey();
        }
    }
}
