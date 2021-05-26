using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiantes.TiposArchivos
{
    class ArchivoTXT : IArchivo
    {
        public void PersistirDatos(Estudiante obj)
        {
            string data = "";

            if (File.Exists("Estudiantes.txt"))
                data = File.ReadAllText("Estudiantes.txt");
            else
                File.Create("Estudiantes.txt").Close();

            using (StreamWriter sw = new StreamWriter("./Estudiantes.txt"))
            {
                data += "\nMatricula: " + obj.Matricula;
                data += "\nNombre: " + obj.Nombre;
                data += "\nApellido: " + obj.Apellido;
                data += "\nCarrera: " + obj.Carrera;
                data += "\nTefono: " + obj.Telefono;
                data += "\nEmail: " + obj.Email;
                data += "\n\"Direccion\"";
                data += "\nCalle: " + obj.Direccion.Calle;
                data += "\nSector: " + obj.Direccion.Sector;
                data += "\nMunicipio: " + obj.Direccion.Municipio;
                data += "\nDescripcion: " + obj.Direccion.Descripcion;
                data += "\n+----------------------------+";

                sw.Write(data);
            }
        }
    }
}
