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
    // Clase para manejar la conexión a la base de datos SQLite y realizar operaciones CRUD en la tabla Alumnos
    public class ConexionDB
    {
        // Cadena de conexión del archivo de configuración
        private static string cadena = ConfigurationManager.ConnectionStrings["ConexionDB"].ConnectionString;
        // Instancia unica Singleton
        private static ConexionDB _instancia = null;

        //Metodo constructor privado
        private ConexionDB()
        {
        }

        //Metodo Instancia para siempre tener una sola instancia de la clase
        public static ConexionDB Instancia()
        {
            if (_instancia == null)
            {
                _instancia = new ConexionDB();
            }
            return _instancia;
        }

        // Metodo para guardar un nuevo alumno en la base de datos
        public (bool, string) GuardarAlumno(Alumno obj)
        {
            //Bool para saber si se guardo correctamente
            bool respuesta = true;
            string mensaje = "Alumno guardado exitosamente.";

            //Try catch para manejar errores
            try
            {
                //Using para abrir y cerrar la conexion
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    //Conexion a la base de datos
                    conn.Open();
                    //Query para agregar un nuevo alumno
                    string query = "INSERT INTO Alumnos (Nombre, Apellido, FechaNacimiento, Edad, Email, AnioIngreso) " +
                                   "VALUES (@Nombre, @Apellido, @FechaNacimiento, @Edad, @Email, @AnioIngreso)";

                    //Creacion del comando SQL y parametros
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                    cmd.Parameters.Add(new SQLiteParameter("@Apellido", obj.Apellido));
                    cmd.Parameters.Add(new SQLiteParameter("@FechaNacimiento", obj.FechaNacimiento));
                    cmd.Parameters.Add(new SQLiteParameter("@Edad", obj.Edad));
                    cmd.Parameters.Add(new SQLiteParameter("@Email", obj.Email));
                    cmd.Parameters.Add(new SQLiteParameter("@AnioIngreso", obj.AnioIngreso));
                    cmd.CommandType = System.Data.CommandType.Text;

                    //Verificacion que se inserto al menos una fila
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
            }
            catch (SQLiteException ex)
            {
                //Manejo de errores
                respuesta = false;
                mensaje = "Error al guardar el alumno: " + ex.Message;

                Console.WriteLine("Error al guardar el alumno: " + ex.Message);
            }

            return (respuesta, mensaje);
        }

        //Metodo para listar todos los alumnos de la base de datos
        public List<Alumno> ListarAlumnos()
        {
            //Cracion de la lista de alumnos
            List<Alumno> lista = new List<Alumno>();
            //Using para abrir y cerrar la conexion
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                //Conexion a la base de datos
                conn.Open();
                //Query para seleccionar todos los alumnos
                string query = "SELECT * FROM Alumnos";

                //Creacion del comando SQL
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.CommandType = System.Data.CommandType.Text;

                //Ejecucion del comando y lectura de los datos
                using (SQLiteDataReader datos = cmd.ExecuteReader())
                {
                    //Lectura de cada dato y creacion del objeto Alumno
                    while (datos.Read())
                    {
                        lista.Add(new Alumno()
                        {
                            Id = Convert.ToInt32(datos["Id"]),
                            Nombre = datos["Nombre"].ToString(),
                            Apellido = datos["Apellido"].ToString(),
                            FechaNacimiento = Convert.ToDateTime(datos["FechaNacimiento"]),
                            Email = datos["Email"].ToString(),
                            AnioIngreso = Convert.ToInt32(datos["AnioIngreso"])
                        });
                    }
                }
            }
            return lista;
        }

        //Metodo para editar un alumno existente en la base de datos
        public bool EditarAlumno(Alumno obj)
        {
            bool respuesta = true;

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string query = "UPDATE Alumnos SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento, " +
                               "Edad = @Edad, Email = @Email, AnioIngreso = @AnioIngreso WHERE Id = @Id";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.Add(new SQLiteParameter("@Nombre", obj.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@Apellido", obj.Apellido));
                cmd.Parameters.Add(new SQLiteParameter("@FechaNacimiento", obj.FechaNacimiento));
                cmd.Parameters.Add(new SQLiteParameter("@Edad", obj.Edad));
                cmd.Parameters.Add(new SQLiteParameter("@Email", obj.Email));
                cmd.Parameters.Add(new SQLiteParameter("@AnioIngreso", obj.AnioIngreso));
                cmd.Parameters.Add(new SQLiteParameter("@Id", obj.Id));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
                return respuesta;
            }

        }

        //Metodo para eliminar un alumno de la base de datos
        public bool EliminarAlumno(Alumno obj)
        {
            //Bool para saber el resultado
            bool respuesta = true;
            //Try catch para manejar errores
            try
            {
                //using para abrir y cerrar la conexion
                using (SQLiteConnection conn = new SQLiteConnection(cadena))
                {
                    //Conexion a la base de datos
                    conn.Open();
                    //Query para eliminar el alumno por Id
                    string query = "DELETE FROM Alumnos WHERE Id = @Id";

                    //Creacion del comando SQL
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.Add(new SQLiteParameter("@Id", obj.Id));
                    cmd.CommandType = System.Data.CommandType.Text;

                    //Verificacion de que se elimino al menos una fila
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        respuesta = false;
                    }
                }
            }
            catch (Exception ex)
            {
                //Mustra el error en consola
                Console.WriteLine("Error al eliminar el alumno: " + ex.Message);
                respuesta = false;
            }
            return respuesta;
        }
    }
}
