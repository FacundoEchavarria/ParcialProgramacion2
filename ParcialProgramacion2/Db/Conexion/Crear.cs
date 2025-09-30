using ParcialProgramacion2.Db.Modelos;
using System.Data.SQLite;

namespace ParcialProgramacion2.Db.Conexion
{
    public partial class ConexionDB
    {
        public (bool, string) GuardarAlumno(Alumno obj)
        {
            bool respuesta = true;
            string mensaje = "Alumno guardado exitosamente.";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();
                    string query = "INSERT INTO Alumnos (Nombre, Apellido, FechaNacimiento, Email, AnioIngreso) " +
                                   "VALUES (@Nombre, @Apellido, @FechaNacimiento, @Email, @AnioIngreso)";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", obj.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Email", obj.Email);
                    cmd.Parameters.AddWithValue("@AnioIngreso", obj.AnioIngreso);

                    if (cmd.ExecuteNonQuery() < 1)
                        respuesta = false;
                }
            }
            catch (SQLiteException ex)
            {
                respuesta = false;
                mensaje = "Error al guardar el alumno: " + ex.Message;
            }

            return (respuesta, mensaje);
        }
    }
}