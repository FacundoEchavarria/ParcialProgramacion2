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

        // -----------------------
        // BOTÓN AGREGAR
        // -----------------------
        private void agregar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno nuevoAlumno = new Alumno()
                {
                    Nombre = nombre_txt.Text,
                    Apellido = apellido_txt.Text,
                    FechaNacimiento = DateTime.Parse(nacimiento_txt.Text),
                    Email = email_txt.Text,
                    AnioIngreso = int.Parse(ingreso_txt.Text)
                };

                var (guardado, mensaje) = ConexionDB.Instancia().GuardarAlumno(nuevoAlumno);

                MessageBox.Show(mensaje);
                if (guardado)
                {
                    CargarAlumnos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar alumno: " + ex.Message);
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
                    MessageBox.Show("Seleccione un alumno de la tabla para modificar.");
                    return;
                }

                Alumno alumnoEditado = new Alumno()
                {
                    Id = int.Parse(id_txt.Text),
                    Nombre = nombre_txt.Text,
                    Apellido = apellido_txt.Text,
                    FechaNacimiento = DateTime.Parse(nacimiento_txt.Text),
                    Email = email_txt.Text,
                    AnioIngreso = int.Parse(ingreso_txt.Text)
                };

                var (editado, mensaje) = ConexionDB.Instancia().EditarAlumno(alumnoEditado);

                MessageBox.Show(mensaje);
                if (editado)
                {
                    CargarAlumnos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar alumno: " + ex.Message);
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
        // BOTÓN BUSCAR
        // -----------------------
        private void buscar_btn_Click(object sender, EventArgs e)
        {
            CargarAlumnos(buscar_txt.Text);
        }

        // -----------------------
        // CLICK EN LA TABLA
        // -----------------------
        private void VerTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && VerTabla.Rows[e.RowIndex].Cells["Id"].Value != null)
            {
                id_txt.Text = VerTabla.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                nombre_txt.Text = VerTabla.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                apellido_txt.Text = VerTabla.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                nacimiento_txt.Text = VerTabla.Rows[e.RowIndex].Cells["FechaNacimiento"].Value.ToString();
                email_txt.Text = VerTabla.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                ingreso_txt.Text = VerTabla.Rows[e.RowIndex].Cells["AnioIngreso"].Value.ToString();
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
            nacimiento_txt.Clear();
            email_txt.Clear();
            ingreso_txt.Clear();
            buscar_txt.Clear();
        }
    }
}
