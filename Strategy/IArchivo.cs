using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    interface IArchivo
    {
        void PersistirDatos(Estudiante obj);
    }
}
