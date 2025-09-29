using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using ParcialProgramacion2.Db.Modelos;
using System.Data.SQLite;
using System.Security.Cryptography;


namespace ParcialProgramacion2.Db.Conexion
{
    public class ConexionDB
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
        private static ConexionDB _instancia = null;

        private ConexionDB()
        {
        }

        public static ConexionDB Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ConexionDB();
            }
            return _instancia;
        }
        
        public bool GuardarAlumno(Alumno obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string query = "INSERT INTO Alumnos (Nombre, Apellido, FechaNacimiento, Edad, Email, AnioIngreso) " +
                               "VALUES (@Nombre, @Apellido, @FechaNacimiento, @Edad, @Email, @AnioIngreso)";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Apellido", obj.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("@FechaNacimiento", obj.FechaNacimiento));
                cmd.Parameters.Add(new SQLiteParameter("@Edad", obj.Edad));
                cmd.Parameters.Add(new SQLiteParameter("@Email", obj.Email));
                cmd.Parameters.Add(new SQLiteParameter("@AnioIngreso", obj.AnioIngreso));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
                return respuesta;
            }

        }

        public List<Alumno> ListarAlumnos()
        {
            List<Alumno> lista = new List<Alumno>();
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string query = "SELECT * FROM Alumnos";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader datos = cmd.ExecuteReader())
                {
                    while (datos.Read())
                    {
                        lista.Add(new Alumno()
                        {
                            Id = Convert.ToInt32(datos["Id"]),
                            Nombre = datos["Nombre"].ToString(),
                            Apellido = datos["Apellido"].ToString(),
                            FechaNacimiento = Convert.ToDateTime(datos["FechaNacimiento"]),
                            Edad = Convert.ToInt32(datos["Edad"]),
                            Email = datos["Email"].ToString(),
                            AnioIngreso = Convert.ToInt32(datos["AnioIngreso"])
                        });
                    }
                }
            }
            return lista;
        }
    }
}
