﻿using System;
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
                    Console.WriteLine("\ningrese un numero de registro a cargar o 0 para dejar de hacerlo\n");
                    strRegistro = Console.ReadLine();
                    if (int.TryParse(strRegistro, out Registro) == false)
                    {
                        Console.WriteLine("\nDebe ingresar un numero entero no vacio\n");
                        flag = true;
                    }
                    else if (DiccionarioDeAlumnos.ContainsKey(Registro) == true)
                    {
                        Console.WriteLine("\nEl valor no puede estar repetido\n");
                        flag = true;
                    }
                } while (flag == true);

                if (Registro != 0)
                {
                    do
                    {
                        strFlag = false;
                        Console.WriteLine("\nIngrese un nombre para el registro\n");
                        Nombre = Console.ReadLine();
                        if (Nombre == "")
                        {
                            Console.WriteLine("\nDebe ingresar un nombre\n");
                            strFlag = true;

                        }
                    } while (strFlag == true);

                    DiccionarioDeAlumnos.Add(Registro, Nombre);
                }

                

            } while (Registro != 0);

            //esto es adicional, muestra el contenido del diccionario hasta ahora

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
                    Console.WriteLine("\ningrese codigo a buscar\n");
                    strBuscaReg = Console.ReadLine();
                    if (int.TryParse(strBuscaReg, out BuscarReg) == false)
                    {
                        Console.WriteLine("\nDebe ingresar un numero entero no vacio\n");
                        flag = true;
                    }
                    else if (DiccionarioDeAlumnos.ContainsKey(BuscarReg) == false && BuscarReg!=0)
                    {
                        Console.WriteLine("\nEl valor no se encuentra, ingrese otro\n");
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
