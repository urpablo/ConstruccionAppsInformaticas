﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Press a console key.");
            Console.WriteLine("Press the x key to quit: \n");
            do
            {
                cki = Console.ReadKey();
                Console.Write(" --- You pressed ");
                //if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                //if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                //if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                Console.WriteLine(cki.Key.ToString());
            } while (cki.Key != ConsoleKey.X);

        }
    }
}
