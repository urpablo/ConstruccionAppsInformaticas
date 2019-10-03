using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Ejercicio._50
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {

            FileDialog fbd = new OpenFileDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine(fbd.FileName);
                

            }

            string text = System.IO.File.ReadAllText(fbd.FileName);
            Console.WriteLine(text);
            Console.ReadKey();


        }
    }
}