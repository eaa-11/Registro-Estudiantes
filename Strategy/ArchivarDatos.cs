using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    class ArchivarDatos
    {
        static AplicarArchivoContexto Aplicar;

        public static void archivarDatos(Estudiante obj)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\"TIPO DE ARCHIVO\"");
                Console.WriteLine("\n1.TXT\n2.JSON\n3.EXCEL");
                Console.Write("\nOpcion: ");
                int opc = Convert.ToInt32(Console.ReadLine());

                Aplicar = new AplicarArchivoContexto(FactoriaArchivo.GetArchivo(opc));
                Aplicar.Archivar(obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!"+ex);
            }
        }
    }
}
