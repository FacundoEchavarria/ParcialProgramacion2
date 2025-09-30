using System;
using System.Configuration;
using System.Data.SQLite;

namespace ParcialProgramacion2.Db.Conexion
{
    public partial class ConexionDB
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
        private static ConexionDB _instancia = null;

        private ConexionDB() { }

        public static ConexionDB Instancia()
        {
            if (_instancia == null)
                _instancia = new ConexionDB();
            return _instancia;
        }



        public static bool EmailExiste(string email, int idExcluir = 0)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Alumnos WHERE Email = @Email";

                    // Si estamos editando, excluir el ID actual
                    if (idExcluir > 0)
                    {
                        query += " AND Id != @Id";
                    }

                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);

                    if (idExcluir > 0)
                    {
                        cmd.Parameters.AddWithValue("@Id", idExcluir);
                    }

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (SQLiteException)
            {
                return false;
            }
        }
    }
}