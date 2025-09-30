using ParcialProgramacion2.Db.Modelos;
using System.Data.SQLite;

namespace ParcialProgramacion2.Db.Conexion
{
    public partial class ConexionDB
    {
        public (bool, string) EditarAlumno(Alumno obj)
        {
            bool respuesta = true;
            string mensaje = "Alumno modificado correctamente.";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();
                    string query = "UPDATE Alumnos SET Nombre=@Nombre, Apellido=@Apellido, FechaNacimiento=@FechaNacimiento, " +
                                   "Email=@Email, AnioIngreso=@AnioIngreso WHERE Id=@Id";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", obj.Apellido);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", obj.FechaNacimiento);
                    cmd.Parameters.AddWithValue("@Email", obj.Email);
                    cmd.Parameters.AddWithValue("@AnioIngreso", obj.AnioIngreso);
                    cmd.Parameters.AddWithValue("@Id", obj.Id);

                    if (cmd.ExecuteNonQuery() < 1)
                        respuesta = false;
                }
            }
            catch (SQLiteException ex)
            {
                respuesta = false;
                mensaje = "Error al modificar alumno: " + ex.Message;
            }

            return (respuesta, mensaje);
        }
    }
}