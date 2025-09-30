using System.Data.SQLite;

namespace ParcialProgramacion2.Db.Conexion
{
    public partial class ConexionDB
    {
        public (bool, string) EliminarAlumno(int id)
        {
            bool respuesta = true;
            string mensaje = "Alumno eliminado correctamente.";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();
                    string query = "DELETE FROM Alumnos WHERE Id=@Id";

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);

                    if (cmd.ExecuteNonQuery() < 1)
                        respuesta = false;
                }
            }
            catch (SQLiteException ex)
            {
                respuesta = false;
                mensaje = "Error al eliminar alumno: " + ex.Message;
            }

            return (respuesta, mensaje);
        }
    }
}