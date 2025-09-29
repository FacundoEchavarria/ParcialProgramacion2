using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgramacion2.Db.Modelos
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public int AnioIngreso { get; set; }

        public int Edad
        {
            get
            {
                DateTime hoy = DateTime.Today;
                int edad = hoy.Year - FechaNacimiento.Year;
                if (hoy < FechaNacimiento.AddYears(edad))
                    edad--;
                return edad;
            }
        }
    }
}
