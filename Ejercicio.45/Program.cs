using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._45
{
    class Program
    {
        static void Main(string[] args)
        {
            var DiccionarioDeAlumnos = new Dictionary<int, string>();
            string strRegistro;
            string Nombre;
            int Registro=0;
            bool flag= false;
            bool strFlag = false;
            string strBuscaReg;
            int BuscarReg;

            //bloque cargar
            do
            {
                do
                {
                    flag = false;
                    Console.WriteLine("ingrese un numero de registro a cargar o 0 para dejar de hacerlo");
                    strRegistro = Console.ReadLine();
                    if (int.TryParse(strRegistro, out Registro) == false)
                    {
                        Console.WriteLine("Debe ingresar un numero entero no vacio");
                        flag = true;
                    }
                    else if (DiccionarioDeAlumnos.ContainsKey(Registro) == true)
                    {
                        Console.WriteLine("El valor no puede estar repetido");
                        flag = true;
                    }
                } while (flag == true);

                if (Registro != 0)
                {
                    do
                    {
                        strFlag = false;
                        Console.WriteLine("Ingrese un nombre para el registro");
                        Nombre = Console.ReadLine();
                        if (Nombre == "")
                        {
                            Console.WriteLine("Debe ingresar un nombre");
                            strFlag = true;

                        }
                    } while (strFlag == true);

                    DiccionarioDeAlumnos.Add(Registro, Nombre);
                }

                

            } while (Registro != 0);



            foreach (KeyValuePair<int, string> kvp in DiccionarioDeAlumnos)
            {
                //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value+"\n");
            }


            //bloque de busqueda

            do
            {
                do
                {
                    flag = false;
                    Console.WriteLine("ingrese codigo a buscar");
                    strBuscaReg = Console.ReadLine();
                    if (int.TryParse(strBuscaReg, out BuscarReg) == false)
                    {
                        Console.WriteLine("Debe ingresar un numero entero no vacio");
                        flag = true;
                    }
                    else if (DiccionarioDeAlumnos.ContainsKey(BuscarReg) == false && BuscarReg!=0)
                    {
                        Console.WriteLine("El valor no se encuentra, ingrese otro");
                        flag = true;
                    }


                } while (flag == true);

                if (BuscarReg != 0)
                {
                    DiccionarioDeAlumnos.TryGetValue(BuscarReg, out Nombre);
                    Console.WriteLine(Nombre);
                }
                

            } while (BuscarReg != 0);







            Console.ReadKey();

        }
    }
}
