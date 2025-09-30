using System.Data;
using System.Data.SQLite;

namespace ParcialProgramacion2.Db.Conexion
{
    public partial class ConexionDB
    {
        public DataTable ListarAlumnos(string filtro = "")
        {
            DataTable tabla = new DataTable();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string query = "SELECT Id, Nombre, Apellido, FechaNacimiento, " +
                               "strftime('%Y','now') - strftime('%Y',FechaNacimiento) AS Edad, " +
                               "Email, AnioIngreso " +
                               "FROM Alumnos";

                if (!string.IsNullOrEmpty(filtro))
                    query += " WHERE Nombre LIKE @filtro OR Apellido LIKE @filtro";

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);

                if (!string.IsNullOrEmpty(filtro))
                    da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                da.Fill(tabla);
            }

            return tabla;
        }
    }
}