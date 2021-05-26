using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace RegistroEstudiantes
{
    class ArchivosJSON : IArchivo
    {
        List<Estudiante> listEstudiantes;

        public void PersistirDatos(Estudiante obj)
        {
            listEstudiantes = GetEstudiantes();
            listEstudiantes.Add(obj);

            string json = JsonSerializer.Serialize<List<Estudiante>>(listEstudiantes);

            using (StreamWriter sw = new StreamWriter("./Estudiantes.json"))
            {
                sw.Write(json);
            }
        }

        public List<Estudiante> GetEstudiantes()
        {
            if (File.Exists("Estudiantes.json"))
            {
                string oldData = File.ReadAllText("Estudiantes.json");

                List<Estudiante> Newdata = JsonSerializer.Deserialize<List<Estudiante>>(oldData);
                return Newdata;
            }
            else
                return new List<Estudiante>();
        }
    }
}