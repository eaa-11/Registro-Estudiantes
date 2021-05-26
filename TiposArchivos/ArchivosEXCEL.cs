using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpreadsheetLight;

namespace RegistroEstudiantes
{
    class ArchivosEXCEL : IArchivo
    {
        List<Estudiante> estudiantes = new List<Estudiante>();

        string ruta = AppDomain.CurrentDomain.BaseDirectory + "./Estudiantes.xlsx";

        public void PersistirDatos(Estudiante obj)
        {
            estudiantes = GetEstudiantes();
            estudiantes.Add(obj);

            SLDocument sLDocument = new SLDocument();

            System.Data.DataTable table = new System.Data.DataTable();

            table.Columns.Add("Matricula", typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Apellido", typeof(string));
            table.Columns.Add("Carrera", typeof(string));
            table.Columns.Add("Telefono", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Calle", typeof(string));
            table.Columns.Add("Sector", typeof(string));
            table.Columns.Add("Municipio", typeof(string));
            table.Columns.Add("Descripcion", typeof(string));

            foreach(var i in estudiantes)
            {
                table.Rows.Add(i.Matricula, i.Nombre, i.Apellido, i.Carrera, i.Telefono, i.Email, 
                i.Direccion.Calle, i.Direccion.Sector,i.Direccion.Municipio,i.Direccion.Descripcion);
            }

            sLDocument.ImportDataTable(1,1,table,true);
            sLDocument.SaveAs(ruta);
        }

        public List<Estudiante> GetEstudiantes()
        {
            if (!File.Exists("Estudiantes.xlsx"))
            {
                return new List<Estudiante>();
            }

            List<Estudiante> listEstudiantes = new List<Estudiante>();

            Estudiante es = new Estudiante();

            SLDocument sl = new SLDocument(ruta);

            int iRow = 2;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
            {
                es.Matricula = sl.GetCellValueAsString(iRow,1);
                es.Nombre = sl.GetCellValueAsString(iRow,2);
                es.Apellido = sl.GetCellValueAsString(iRow,3);
                es.Carrera = sl.GetCellValueAsString(iRow,4);
                es.Telefono = sl.GetCellValueAsString(iRow,5);
                es.Email = sl.GetCellValueAsString(iRow,6);
                es.Direccion.Calle = sl.GetCellValueAsString(iRow,7);
                es.Direccion.Sector = sl.GetCellValueAsString(iRow,8);
                es.Direccion.Municipio = sl.GetCellValueAsString(iRow,9);
                es.Direccion.Descripcion = sl.GetCellValueAsString(iRow, 10);
                listEstudiantes.Add(es);
                iRow++;
            }
            return listEstudiantes;
        }
    }
}
