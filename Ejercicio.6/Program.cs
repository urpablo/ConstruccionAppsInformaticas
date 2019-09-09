using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._6
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            // Prevent example from ending if CTL+C is pressed.
            Console.TreatControlCAsInput = true;

            Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
            Console.WriteLine("Press the Escape (Esc) key to quit: \n");
            bool flag = true;
            do
            {
                cki = Console.ReadKey();
                Console.Write(" --- You pressed ");
                if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0 && (cki.Modifiers & ConsoleModifiers.Shift) != 0 && cki.Key == ConsoleKey.F) flag = false;
                if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                Console.WriteLine(cki.Key.ToString());
            } while (flag == true);
        }
    }
}
