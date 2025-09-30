using System;
using System.Data;
using System.Windows.Forms;
using ParcialProgramacion2.Db.Conexion;
using ParcialProgramacion2.Db.Modelos;

namespace ParcialProgramacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void CargarAlumnos(string filtro = "")
        {
            dataGridView1.DataSource = ConexionDB.Instancia().ListarAlumnos(filtro);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            CargarAlumnos(buscar_txt.Text);
        }

        // -----------------------
        // BOTÓN AGREGAR
        // -----------------------
        private void agregar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos obligatorios
                if (!ValidarCamposObligatorios())
                    return;

                // Validar año de ingreso
                if (!ValidarAnioIngreso(out int anioIngreso))
                    return;

                // Validar fecha de nacimiento
                if (!ValidarFechaNacimiento())
                    return;

                // Validar email
                if (!ValidarEmail(email_txt.Text.Trim()))
                    return;

                // Verificar que el email no esté repetido
                if (ConexionDB.EmailExiste(email_txt.Text.Trim()))
                {
                    MessageBox.Show("El email ya está registrado. Por favor, use otro email.",
                        "Email duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    email_txt.Focus();
                    return;
                }

                Alumno nuevoAlumno = new Alumno()
                {
                    Nombre = nombre_txt.Text.Trim(),
                    Apellido = apellido_txt.Text.Trim(),
                    FechaNacimiento = nacimiento_dtp.Value,
                    Email = email_txt.Text.Trim(),
                    AnioIngreso = anioIngreso
                };

                var (guardado, mensaje) = ConexionDB.Instancia().GuardarAlumno(nuevoAlumno);

                MessageBox.Show(mensaje, guardado ? "Éxito" : "Error",
                    MessageBoxButtons.OK, guardado ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (guardado)
                {
                    CargarAlumnos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar alumno: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -----------------------
        // BOTÓN MODIFICAR
        // -----------------------
        private void modificar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id_txt.Text))
                {
                    MessageBox.Show("Seleccione un alumno de la tabla para modificar.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar campos obligatorios
                if (!ValidarCamposObligatorios())
                    return;

                // Validar año de ingreso
                if (!ValidarAnioIngreso(out int anioIngreso))
                    return;

                // Validar fecha de nacimiento
                if (!ValidarFechaNacimiento())
                    return;

                // Validar email
                if (!ValidarEmail(email_txt.Text.Trim()))
                    return;

                int idActual = int.Parse(id_txt.Text);

                // Verificar que el email no esté repetido (excepto el mismo alumno)
                if (ConexionDB.EmailExiste(email_txt.Text.Trim(), idActual))
                {
                    MessageBox.Show("El email ya está registrado por otro alumno.",
                        "Email duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    email_txt.Focus();
                    return;
                }

                Alumno alumnoEditado = new Alumno()
                {
                    Id = idActual,
                    Nombre = nombre_txt.Text.Trim(),
                    Apellido = apellido_txt.Text.Trim(),
                    FechaNacimiento = nacimiento_dtp.Value,
                    Email = email_txt.Text.Trim(),
                    AnioIngreso = anioIngreso
                };

                var (editado, mensaje) = ConexionDB.Instancia().EditarAlumno(alumnoEditado);

                MessageBox.Show(mensaje, editado ? "Éxito" : "Error",
                    MessageBoxButtons.OK, editado ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (editado)
                {
                    CargarAlumnos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar alumno: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // -----------------------
        // BOTÓN ELIMINAR
        // -----------------------
        private void eliminar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id_txt.Text))
                {
                    MessageBox.Show("Seleccione un alumno de la tabla para eliminar.");
                    return;
                }

                int id = int.Parse(id_txt.Text);

                var (eliminado, mensaje) = ConexionDB.Instancia().EliminarAlumno(id);

                MessageBox.Show(mensaje);
                if (eliminado)
                {
                    CargarAlumnos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar alumno: " + ex.Message);
            }
        }

        // -----------------------
        // CLICK EN LA TABLA
        // -----------------------
        private void VerTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["Id"].Value != null)
            {
                id_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                nombre_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                apellido_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();

                // CAMBIADO: convertir a DateTime y asignar al DateTimePicker
                if (DateTime.TryParse(dataGridView1.Rows[e.RowIndex].Cells["FechaNacimiento"].Value.ToString(), out DateTime fechaNac))
                {
                    nacimiento_dtp.Value = fechaNac;
                }

                email_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                ingreso_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["AnioIngreso"].Value.ToString();
            }
        }

        // -----------------------
        // MÉTODO AUXILIAR
        // -----------------------
        private void LimpiarCampos()
        {
            id_txt.Clear();
            nombre_txt.Clear();
            apellido_txt.Clear();
            nacimiento_dtp.Value = DateTime.Now;
            email_txt.Clear();
            ingreso_txt.Clear();
            buscar_txt.Clear();
        }












        // -----------------------
        // MÉTODOS DE VALIDACIÓN
        // -----------------------

        /// <summary>
        /// Valida que los campos obligatorios no estén vacíos
        /// </summary>
        private bool ValidarCamposObligatorios()
        {
            if (string.IsNullOrWhiteSpace(nombre_txt.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nombre_txt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(apellido_txt.Text))
            {
                MessageBox.Show("El campo Apellido es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                apellido_txt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(email_txt.Text))
            {
                MessageBox.Show("El campo Email es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email_txt.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(ingreso_txt.Text))
            {
                MessageBox.Show("El campo Año de Ingreso es obligatorio.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ingreso_txt.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida que la fecha de nacimiento no sea futura
        /// </summary>
        private bool ValidarFechaNacimiento()
        {
            if (nacimiento_dtp.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nacimiento_dtp.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida que el año de ingreso sea un número entero mayor a 2000 y no superior al año actual
        /// </summary>
        private bool ValidarAnioIngreso(out int anioIngreso)
        {
            anioIngreso = 0;

            if (!int.TryParse(ingreso_txt.Text.Trim(), out anioIngreso))
            {
                MessageBox.Show("El Año de Ingreso debe ser un número entero válido.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ingreso_txt.Focus();
                return false;
            }

            if (anioIngreso <= 2000)
            {
                MessageBox.Show("El Año de Ingreso debe ser mayor a 2000.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ingreso_txt.Focus();
                return false;
            }

            if (anioIngreso > DateTime.Now.Year)
            {
                MessageBox.Show($"El Año de Ingreso no puede ser superior al año actual ({DateTime.Now.Year}).",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ingreso_txt.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Valida que el email tenga un formato básico correcto
        /// </summary>
        private bool ValidarEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            // Validación básica de formato de email
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("El formato del email no es válido.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email_txt.Focus();
                return false;
            }

            return true;
        }
    }
}