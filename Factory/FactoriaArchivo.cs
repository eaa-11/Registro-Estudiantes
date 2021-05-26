using RegistroEstudiantes.TiposArchivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    class FactoriaArchivo
    {

        public static IArchivo GetArchivo(int opc)
        {
            switch (opc)
            {
                case 1:
                    return new ArchivoTXT();
                case 2:
                    return new ArchivosJSON();
                case 3:
                    return new ArchivosEXCEL();
                default:
                    Console.WriteLine("N/A!");
                    break;
            }
            return null;
        }
    }
}
