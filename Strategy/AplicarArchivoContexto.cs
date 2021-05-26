using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    class AplicarArchivoContexto
    {
        IArchivo datos;

        public AplicarArchivoContexto(IArchivo obj)
        {
            datos = obj;
        }

        public void Archivar(Estudiante obj)
        { 
            datos.PersistirDatos(obj);
        }
    }
}
