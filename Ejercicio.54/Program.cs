using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio._54
{
    class Program
    {
        static void Main(string[] args)
        {
            var alumnos = new Dictionary<int, string>();
            var curso = new Dictionary<int, string>();
            string comando="";
            int Reg;
            string strReg;
            bool flag = false;
            string nombre;

            while (comando.ToUpper() != "SALIR")
            {
                Console.WriteLine("a.	Dar de alta un alumno (Número de registro y nombre completo)\n" +
                    "b.	Dar de alta un curso (se ingresa el código del curso)\n" +
                    "c.	Asignar un alumno a un curso.\n" +
                    "d.	Desasignar un alumno de un curso.\n" +
                    "e.	Ver la lista de alumnos asignados a un curso.\n" +
                    "f.	Ver los cursos a los que está asignado un alumno.\n" +
                    "g.	Ver la cantidad de alumnos en cada curso.\n" +
                    "h.	Ver la cantidad de cursos de cada alumno.\n" +
                    "g. Salir\n");
                comando = Console.ReadLine();

                switch (comando.ToUpper())
                {
                    case "A":
                        do
                        {
                            Console.WriteLine("Ingrese nro de Reg");
                            strReg = Console.ReadLine();
                            if (int.TryParse(strReg, out Reg) == false)
                            {
                                flag = true;
                              
                            }
                            else
                            {
                                flag = false;
                            }
                        } while (flag == true);

                        do
                        {
                            Console.WriteLine("Ingrese Nombre");
                            nombre = Console.ReadLine();
                        } while (nombre == "");

                        alumnos.Add(Reg, nombre);







                        break;
                }

            }
            
        }
    }
}
