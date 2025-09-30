using ParcialProgramacion2.Db.Conexion;
using ParcialProgramacion2.Db.Modelos;
using ParcialProgramacion2.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ParcialProgramacion2
{
    public partial class Form1 : Form
    {
        //Constructor del formulario
        public Form1()
        {
            InitializeComponent();
            //ejecuta la funcion Form1_Load al cargar el formulario
            Load += Form1_Load;
            //
            dataGridView1.CellContentClick += botonesGrilla;
        }
        //Funcion para cargar los alumnos en el DataGridView
        private void CargarAlumnos(List<Alumno> lista)
        {
            //Si la lista esta vacia, muestra un mensaje y carga todos los alumnos
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No se encontraron alumnos. Se mostrarán todos.");

                lista = ConexionDB.Instancia().ListarAlumnos();
            }

            //Configura el DataGridView para mostrar la lista de alumnos
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;

            //Agregar botones de eliminar y editar si no existen
            if (dataGridView1.Columns["eliminarBtn"] == null)
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "eliminarBtn";
                btnCol.HeaderText = "Eliminar";
                btnCol.Text = "Eliminar";
                btnCol.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(btnCol);
            }

            if (dataGridView1.Columns["editarBtn"] == null)
            {
                DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "editarBtn";
                btnCol.HeaderText = "Editar";
                btnCol.Text = "Editar";
                btnCol.UseColumnTextForButtonValue = true;

                dataGridView1.Columns.Add(btnCol);
            }

            //Agrega los botones al final
            dataGridView1.Columns["editarBtn"].DisplayIndex = dataGridView1.Columns.Count - 1;
            dataGridView1.Columns["eliminarBtn"].DisplayIndex = dataGridView1.Columns.Count - 1;
        }

        //Funcion para cargar los alumnos al iniciar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarAlumnos(ConexionDB.Instancia().ListarAlumnos());
        }

        //Funcion para eliminar un alumno al hacer click en el boton eliminar
        private void botonesGrilla(object sender, DataGridViewCellEventArgs e)
        {
            //Verificar si se hizo click en el boton eliminar
            if (dataGridView1.Columns[e.ColumnIndex].Name == "eliminarBtn" && e.RowIndex >= 0)
            {
                //Obtiene el alumno de esa fila
                Alumno alumno = (Alumno)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                //Crea el mensaje de confirmacion
                DialogResult confirmarEliminacion = MessageBox.Show(
                   $"¿Seguro que querés eliminar a {alumno.Nombre}?",
                   "Confirmar eliminación",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning
                );

                //Si la respuesta es si, elimina el alumno
                if (confirmarEliminacion == DialogResult.Yes)
                {
                    //Elimina el alumno de la base de datos
                    bool eliminado = ConexionDB.Instancia().EliminarAlumno(alumno);

                    //Verifica si se elimino correctamente y recarga la lista de alumnos
                    if (eliminado)
                    {
                        MessageBox.Show("Alumno eliminado correctamente.");
                        CargarAlumnos(ConexionDB.Instancia().ListarAlumnos());
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el alumno.");
                    }
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "editarBtn" && e.RowIndex >= 0)
            {
                //Obtiene el alumno de esa fila
                Alumno alumno = (Alumno)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                limpiarLabels();

                //Carga los datos del alumno en los TextBox
                id_txt.Text = alumno.Id.ToString();
                nombre_txt.Text = alumno.Nombre.Trim();
                apellido_txt.Text = alumno.Apellido.Trim();
                nacimiento_txt.Text = alumno.FechaNacimiento.ToString("dd/MM/yyyy");
                email_txt.Text = alumno.Email.Trim();
                ingreso_txt.Text = alumno.AnioIngreso.ToString();
            }
        }

        //Funcion para agregar un nuevo alumno depues de hacer click en el boton agregar
        private void button1_Click(object sender, EventArgs e)
        {
            var (validacionDatos, validacionMensaje) = Validaciones.ValidacionTotal(email_txt.Text, ingreso_txt.Text, nacimiento_txt.Text, nombre_txt.Text, apellido_txt.Text);
            if (!validacionDatos)
            {
                MessageBox.Show(validacionMensaje);
                return;
            }
            else
            {
                string nombre = capitalizacion(nombre_txt.Text.Trim());
                string apellido = capitalizacion(apellido_txt.Text.Trim());
                string email = email_txt.Text.Trim();
                int anioIngreso = int.Parse(ingreso_txt.Text.Trim());
                DateTime fechaNacimiento = DateTime.Parse(nacimiento_txt.Text.Trim());

                //Crear un nuevo objeto Alumno con los datos ingresados en los TextBox
                Alumno nuevoAlumno = new Alumno()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    FechaNacimiento = fechaNacimiento,
                    Email = email,
                    AnioIngreso = anioIngreso
                };
                //Guardar el nuevo alumno en la base de datos
                var (guardado, mensaje) = ConexionDB.Instancia().GuardarAlumno(nuevoAlumno);

                //Mostrar mensaje de exito o error
                if (guardado)
                {
                    MessageBox.Show(mensaje);
                    CargarAlumnos(ConexionDB.Instancia().ListarAlumnos());
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
                //Limpiar los TextBox
                limpiarLabels();
                
            }
        }

        //Funcion para hacer busquedas
        private void buscar_btn_Click(object sender, EventArgs e)
        {
            //Recibe la lista de alumnos completa
            List<Alumno> listaAlumnos = ConexionDB.Instancia().ListarAlumnos();
            //Normaliza el texto de busqueda a minusculas
            string busqueda = buscar_txt.Text.ToLower().Trim();
            //Filtra la lista de alumnos por nombre, apellido o nombre completo
            List<Alumno> listaFiltrada = listaAlumnos.Where(a => {
                string nombre = a.Nombre.ToLower();
                string apellido = a.Apellido.ToLower();
                string nombreCompleto = $"{nombre} {apellido}";
                return nombre.Contains(busqueda) ||
                       apellido.Contains(busqueda) ||
                       nombreCompleto.Contains(busqueda);
            }).ToList();
            //Recarga el DataGridView con la lista filtrada y limpia el TextBox de busqueda
            CargarAlumnos(listaFiltrada);
            buscar_txt.Text = "";
        }

        //Funcion para limpiar los labels
        private void limpiarLabels()
        {
            id_txt.Text = "";
            nombre_txt.Text = "";
            apellido_txt.Text = "";
            nacimiento_txt.Text = "";
            email_txt.Text = "";
            ingreso_txt.Text = "";
        }

        //Funcion para resetear la busqueda y mostrar todos los alumnos
        private void button1_Click_1(object sender, EventArgs e)
        {
            CargarAlumnos(ConexionDB.Instancia().ListarAlumnos());
        }

        //Funcion para modificar un alumno
        private void modificar_btn_Click(object sender, EventArgs e)
        {
            var (validacionDatos, validacionMensaje) = Validaciones.ValidacionTotal(email_txt.Text, ingreso_txt.Text, nacimiento_txt.Text, nombre_txt.Text, apellido_txt.Text);
            if (!validacionDatos)
            {
                MessageBox.Show(validacionMensaje);
                return;
            }

            if (string.IsNullOrEmpty(id_txt.Text))
            {
                MessageBox.Show("Selecccione un alumno para editar");
                return;
            }

            string nombre = capitalizacion(nombre_txt.Text.Trim());
            string apellido = capitalizacion(apellido_txt.Text.Trim());

            //Crear un nuevo objeto Alumno con los datos ingresados en los TextBox
            Alumno nuevoAlumno = new Alumno()
            {
                Id = int.Parse(id_txt.Text.Trim()),
                Nombre = nombre,
                Apellido = apellido,
                FechaNacimiento = DateTime.Parse(nacimiento_txt.Text.Trim()),
                Email = email_txt.Text.Trim(),
                AnioIngreso = int.Parse(ingreso_txt.Text.Trim())
            };
            //Guardar el nuevo alumno en la base de datos
            var guardado = ConexionDB.Instancia().EditarAlumno(nuevoAlumno);

            //Mostrar mensaje de exito o error
            if (guardado)
            {
                MessageBox.Show("Se edito exitosamente al alumno.");
                CargarAlumnos(ConexionDB.Instancia().ListarAlumnos());
            }
            else
            {
                MessageBox.Show("Hubo un error");
            }
            //Limpiar los TextBox
            limpiarLabels();
        }

        //Funcion para normalizar texto
        public static string capitalizacion(string texto)
        {
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }
    }
}
