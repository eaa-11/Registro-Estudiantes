using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    class MenuPrincipal
    {
        static EstudianteDAO registro = new EstudianteDAO();
        static Estudiante obj = new Estudiante();

        public static void Menu()
        {
            try
            {
                int opc = 0;
                do
                {
                    Console.Clear();

                    Console.WriteLine("\"SISTEMA DE REGISTRO DE ESTUDIANTES\"");
                    Console.WriteLine("\nQue desea hacer? ");
                    Console.WriteLine("\n1.Registrar Estudiantes \n2.Salir");
                    Console.Write("\nOpcion: ");
                    opc = Convert.ToInt32(Console.ReadLine());

                    if (opc == 1)
                        registro.AgregarEstudiantes(obj);
                    else if (opc == 2)
                        break;
                    else
                        Console.WriteLine("N/A!");
                    Thread.Sleep(2000);

                } while (opc != 2);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!"+ex);
                Thread.Sleep(2000);
                Menu();
            }
        }
    }
}
