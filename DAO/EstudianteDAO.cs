using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    class EstudianteDAO
    {
        public bool AgregarEstudiantes(Estudiante obj)
        {
            Console.Clear();     
            try
            {
                Console.WriteLine("FORMULARIO DE REGISTRO...\n");
                Console.Write("Matricula: ");
                obj.Matricula = Console.ReadLine();;
                Console.Write("Nombre: ");
                obj.Nombre = Console.ReadLine();
                Console.Write("Apellido: ");
                obj.Apellido = Console.ReadLine();
                Console.Write("Carrera: ");
                obj.Carrera = Console.ReadLine();
                Console.Write("Telefono: ");
                obj.Telefono = Console.ReadLine();
                Console.Write("Email: ");
                obj.Email = Console.ReadLine();
                Console.WriteLine("\n\"Direccion Del Estudiante\"");
                Console.Write("\nCalle: ");
                obj.Direccion.Calle = Console.ReadLine();
                Console.Write("Sector: ");
                obj.Direccion.Sector = Console.ReadLine();
                Console.Write("Municipio: ");
                obj.Direccion.Municipio = Console.ReadLine();
                Console.Write("Descripcion: ");
                obj.Direccion.Descripcion = Console.ReadLine();

                Console.WriteLine("\nDesea persistir estos datos?");
                Console.Write("1.Si\n2.No");
                Console.Write("\nOpcion: ");
                int opc = Convert.ToInt32(Console.ReadLine());

                if (opc == 1)
                {
                    ArchivarDatos.archivarDatos(obj);
                    Console.WriteLine("\nEstudiante Archivado!");
                    Thread.Sleep(2000);
                    return true;
                }
                else
                {
                    Console.WriteLine("\nNo se que poner aqui :/");
                    Thread.Sleep(2000);
                    return false;
                } 
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!"+ex);
                Thread.Sleep(2000);
                return false;
            }
        }
    }
}
