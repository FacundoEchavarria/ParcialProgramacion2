using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Alumno> lista = ConexionDB.Instancia().ListarAlumnos();
            // Configurar que no genere columnas automáticas si querés definirlas vos
            dataGridView1.AutoGenerateColumns = true;

            // Asignar la lista como origen de datos
            dataGridView1.DataSource = lista;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            if (guardado)
            {
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(ConexionDB.Instancia().ListarAlumnos()[0].Nombre);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
