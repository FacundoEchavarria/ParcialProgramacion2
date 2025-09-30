using System.Configuration;

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
    }
}