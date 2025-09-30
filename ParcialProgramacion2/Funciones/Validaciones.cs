using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgramacion2.Funciones
{
    public static class Validaciones
    {
        public static (bool, string) ValidarEmail(string email)
        {
            //Validar que no este vacio y que contenga un @ y un .
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
            {
                return (false, "El email no es valido");
            }
            //Validar que el @ no este al principio o al final
            int atIndex = email.IndexOf("@");
            if (atIndex <= 0 || atIndex == email.Length - 1)
            {
                return (false, "El email no es valido");
            }
            //Validar que el . no este al principio o al final
            int dotIndex = email.LastIndexOf(".");
            if (dotIndex <= 0 || dotIndex == email.Length - 1)
            {
                return (false, "El email no es valido");
            }
            //Validar que el . este depues del @
            if (dotIndex < atIndex)
            {
                return (false, "El email no es valido");
            }
            return (true, "");
        }

        public static (bool, string) ValidarAnioIngreso(string anioIngreso)
        {
            if(string.IsNullOrWhiteSpace(anioIngreso))
            {
                return (false, "El año de ingreso no puede estar vacio.");
            }
            int anio;
            if (!int.TryParse(anioIngreso, out anio))
            {
                return (false, "El año de ingreso no es valido.");
            }
            int anioActual = DateTime.Now.Year;
            if (anio > anioActual || anio < 2000)
            {
                return (false, "El año de ingreso no es valido.");
            }
            return (true, "");
        }

        public static (bool, string) ValidarFechaNacimiento(string fechaNacimiento)
        {
            if (string.IsNullOrWhiteSpace(fechaNacimiento))
            {
                return (false, "La fecha de nacimiento no puede estar vacia.");
            }
            if(!DateTime.TryParse(fechaNacimiento, out DateTime fecha))
            {
                return (false, "La fecha de nacimiento no es valida.");
            }
            DateTime hoy = DateTime.Today;
            if (fecha > hoy)
            {
                return (false, "La fecha de nacimiento no puede ser futura.");
            }
            return (true, "");
        }

        public static (bool, string) ValidarNombre(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return (false, "El nombre y apellido no puede estar vacio.");
            }
            return (true, "");
        }

        public static (bool, string) ValidacionTotal(string email, string anioIngreso, string fechaNacimiento, string nombre, string apellido)
        {
            var (emailValido, emailMensaje) = ValidarEmail(email);
            var (anioValido, anioMensaje) = ValidarAnioIngreso(anioIngreso);
            var (fechaValida, fechaMensaje) = ValidarFechaNacimiento(fechaNacimiento);
            var (nombreValido, nombreMensaje) = ValidarNombre(nombre);
            var (apellidoValido, apellidoMensaje) = ValidarNombre(apellido);


            if (!nombreValido)
            {
                return (false, nombreMensaje);
            }
            if (!apellidoValido)
            {
                return (false, apellidoMensaje);
            }
            if (!fechaValida)
            {
                return (false, fechaMensaje);
            }
            if (!emailValido)
            {
                return (false, emailMensaje);
            }
            if (!anioValido)
            {
                return (false, anioMensaje);
            }
            return (true, "Todos los datos son validos.");
        }
    }
}
