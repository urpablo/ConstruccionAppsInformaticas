using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una palabra");
            String str = Console.ReadLine();
           

            // copy the string str to chars  
            // character array & it will start 
            // copy from 'G' to 's', i.e.  
            // beginning to ending of string 
            char[] chars = str.ToCharArray();

            Console.WriteLine("String: " + str);
            Console.WriteLine("Character array :");

            // to display the resulted character array 
            //for ( i = 0; i < chars.Length; i++)
            //   Console.Write(" " + chars[i]);

            Array.Reverse(chars);
            foreach (char i in chars)
                Console.WriteLine(i);


            Console.ReadKey();
        }
    }
}
