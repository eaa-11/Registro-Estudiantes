using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiantes
{
    class Estudiante
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Carrera { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Direccion Direccion { get; set; }

        public Estudiante()
        {
            Direccion = new Direccion();

        }
    }
}
