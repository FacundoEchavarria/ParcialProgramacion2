using System;
using System.Windows.Forms;

namespace ParcialProgramacion2.Validaciones
{
    public static class ValidacionesAlumno
    {
        /// <summary>
        /// Valida que los campos obligatorios no estén vacíos
        /// </summary>
        public static bool ValidarCamposObligatorios(
            TextBox nombreTxt,
            TextBox apellidoTxt,
            TextBox emailTxt,
            TextBox ingresoTxt)
        {
            if (string.IsNullOrWhiteSpace(nombreTxt.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nombreTxt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(apellidoTxt.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                apellidoTxt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(emailTxt.Text))
            {
                MessageBox.Show("El campo Email es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTxt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(ingresoTxt.Text))
            {
                MessageBox.Show("El campo Año de Ingreso es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ingresoTxt.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida que la fecha de nacimiento no sea futura
        /// </summary>
        public static bool ValidarFechaNacimiento(DateTimePicker nacimientoDtp)
        {
            if (nacimientoDtp.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nacimientoDtp.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida que el año de ingreso sea un número entero mayor a 2000 y no superior al año actual
        /// </summary>
        public static bool ValidarAnioIngreso(TextBox ingresoTxt, out int anioIngreso)
        {
            anioIngreso = 0;

            if (!int.TryParse(ingresoTxt.Text.Trim(), out anioIngreso))
            {
                MessageBox.Show("El Año de Ingreso debe ser un número entero válido.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ingresoTxt.Focus();
                return false;
            }

            if (anioIngreso <= 2000)
            {
                MessageBox.Show("El Año de Ingreso debe ser mayor a 2000.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ingresoTxt.Focus();
                return false;
            }

            if (anioIngreso > DateTime.Now.Year)
            {
                MessageBox.Show($"El Año de Ingreso no puede ser superior al año actual ({DateTime.Now.Year}).",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ingresoTxt.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida que el email tenga un formato básico correcto
        /// </summary>
        public static bool ValidarEmail(TextBox emailTxt)
        {
            string email = emailTxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Validación básica de formato de email
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("El formato del email no es válido.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                emailTxt.Focus();
                return false;
            }

            return true;
        }
    }
}