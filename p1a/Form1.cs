using p1a.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace p1a
{
    public partial class Form1 : Form
    {
        //definimos una variable de instancia ref a la clase personajeDB
        private PersonajesDB personaje;
        // Lista de razas
        private string[] razasDragonBall = { //compañia consolas
    "Android",
    "Bio-Android",
    "Humana",
    "Humano",
    "Majin",
    "Namekuseijin",
    "Saiyajin",
    "Saiyajin/Humano",
    "Saiyajin/Saiyajin"
};

            public Form1()
        {
            InitializeComponent();
            personaje = new PersonajesDB();
        }


        //Botton para confirmar la conexion con la base de datos 
        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            if (personaje.ProbarConexion())
            {
                MessageBox.Show("Simoncho! 👍👍👍👍👍👍");
            }
            else
            {
                MessageBox.Show("Nel Pastel 😥😥😥😥😥");
            }

        }


        //Para cargar los datos
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = personaje.LeerPersonajes();
            dataGridView1Personajes.DataSource = dt;
        }


        //El boton para crear personaje
        private void button3Crear_Click(object sender, EventArgs e)
        {
            string nombre = textBox2Nombre.Text;
            string raza = comboBoxraza.Text;
            int nivelPoder = (int)numericUpDown1Nivelpoder.Value;
            int respuesta = personaje.CrearPersonaje(nombre, raza, nivelPoder);

            if (respuesta > 0)
            {
                MessageBox.Show("Creado con Exito 👍");
                dataGridView1Personajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("te equivocaste");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxraza.Items.AddRange(razasDragonBall);
        }


        private void buttonBuscarporID_Click(object sender, EventArgs e)
        {
            int idpersonajebuscar = int.Parse(textBox1ID.Text);
            DataTable personajeEncontrado = personaje.BuscarPersonajePorId(idpersonajebuscar);

            if (personajeEncontrado.Rows.Count > 0)
            {

                string nombre = personajeEncontrado.Rows[0]["Nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                DateTime FechaCreacion = DateTime.Parse(personajeEncontrado.Rows[0]["Fecha_Creacion"].ToString());
                string historia = personajeEncontrado.Rows[0]["Historia"].ToString();
                textBox2Nombre.Text = nombre;
                comboBoxraza.Text = raza;
                numericUpDown1Nivelpoder.Value = nivelPoder;
                dateTimePicker1.Value = FechaCreacion;
                textBoxHistoria.Text = historia;
            }
            else
            {
                MessageBox.Show("No se encontro el personaje con ID:" + idpersonajebuscar);

            }
        }


        private void BuscarNombre()
        {
            string nombrePersonajeBuscar = textBox2Nombre.Text;
            DataTable nombreEncontrado = personaje.NombreABuscar(nombrePersonajeBuscar);

            if (nombreEncontrado.Rows.Count > 0)
            {
                int Id = int.Parse(nombreEncontrado.Rows[0]["id"].ToString());
                string raza = nombreEncontrado.Rows[0]["raza"].ToString();
                int nivelPoder = int.Parse(nombreEncontrado.Rows[0]["nivel_poder"].ToString());
                DateTime FechaCreacion = DateTime.Parse(nombreEncontrado.Rows[0]["Fecha_Creacion"].ToString());
                string historia = nombreEncontrado.Rows[0]["Historia"].ToString();
                textBox1ID.Text = Id.ToString();
                comboBoxraza.Text = raza;
                numericUpDown1Nivelpoder.Value = nivelPoder;
                dateTimePicker1.Value = FechaCreacion;
                textBoxHistoria.Text = historia;
            }
            else
            {
                MessageBox.Show("No se encontró el nombre: " + nombrePersonajeBuscar);
            }
        }















        private void button4Buscar_Click(object sender, EventArgs e)
        {
            BuscarNombre();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxraza.Text = " ";
            textBoxHistoria.Text = "";
            textBox1ID.Text = "";
            numericUpDown1Nivelpoder.Value = numericUpDown1Nivelpoder.Minimum;
            textBox2Nombre.Text = "";
        }

        private void comboBoxraza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
