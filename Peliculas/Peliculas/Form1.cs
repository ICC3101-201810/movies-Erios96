using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Peliculas
{
    public partial class Form1 : Form
    {
        BaseDeDatos basededatos;
        Persona prueba;
        public Form1()
        {
            if (File.Exists("../Serialize.txt"))
            {
                BinaryFormatter bin = new BinaryFormatter();
                Stream stream = new FileStream("../../Serialize.txt", FileMode.Open, FileAccess.Read);
                basededatos = new BaseDeDatos();
                basededatos = (BaseDeDatos)bin.Deserialize(stream);
            }
            else
            {
                basededatos = new BaseDeDatos();
            }
            InitializeComponent();
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach(Pelicula p in basededatos.GetPeliculas())
            {
                String nombre = p.GetNombre();
                comboBox1.Items.Add(nombre);
            }
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String nombre = comboBox1.Text;
            foreach (Pelicula p in basededatos.GetPeliculas())
            {
                if(p.GetNombre() == nombre)
                {
                    listBox1.Items.Add("Nombre: " + p.GetNombre());
                    listBox1.Items.Add("Director: " + p.GetDirector().GetNombre());
                    listBox1.Items.Add("Fecha de estreno: " + p.GetEstreno().ToString());
                    listBox1.Items.Add("Descripcion: " + p.GetDescripcion());
                    listBox1.Items.Add("Presupuesto: " + p.GetPresupuesto());
                    listBox1.Items.Add("Estudio: " + p.GetEstudio().GetNombre());
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String nombre = comboBox2.Text;
            foreach (Persona p in basededatos.GetPersonas())
            {
                if (p.GetNombre() == nombre)
                {
                    listBox2.Items.Add("Nombre: " + p.GetNombre());
                    listBox2.Items.Add("Apellido: " + p.GetApellido());
                    listBox2.Items.Add("Fecha de nacimiento: " + p.GetFechaNacimiento().ToString());
                    listBox2.Items.Add("Bibliografia: " + p.GetBibliografia());
                    listBox4.Items.Add("Peliculas: ");
                    foreach (String a in basededatos.ObtenerPeliculasActor(p))
                    {
                        listBox4.Items.Add(a);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Persona p in basededatos.GetPersonas())
            {
                if(p.GetTipo() == "actor")
                {
                    String nombre = p.GetNombre();
                    comboBox2.Items.Add(nombre);
                }
            }
            panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            comboBox2.Items.Clear();
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Persona p in basededatos.GetPersonas())
            {
                if (p.GetTipo() == "director")
                {
                    String nombre = p.GetNombre();
                    comboBox3.Items.Add(nombre);
                }
            }
            panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            panel4.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String nombre = comboBox3.Text;
            foreach (Persona p in basededatos.GetPersonas())
            {
                if (p.GetNombre() == nombre)
                {
                    listBox2.Items.Add("Nombre: " + p.GetNombre());
                    listBox2.Items.Add("Apellido: " + p.GetApellido());
                    listBox2.Items.Add("Fecha de nacimiento: " + p.GetFechaNacimiento().ToString());
                    listBox2.Items.Add("Bibliografia: " + p.GetBibliografia());
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            comboBox3.Items.Clear();
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Persona p in basededatos.GetPersonas())
            {
                if (p.GetTipo() == "productor")
                {
                    String nombre = p.GetNombre();
                    comboBox4.Items.Add(nombre);
                }
            }
            panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            panel5.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String nombre = comboBox4.Text;
            foreach (Persona p in basededatos.GetPersonas())
            {
                if (p.GetNombre() == nombre)
                {
                    listBox4.Items.Add("Nombre: " + p.GetNombre());
                    listBox4.Items.Add("Apellido: " + p.GetApellido());
                    listBox4.Items.Add("Fecha de nacimiento: " + p.GetFechaNacimiento().ToString());
                    listBox4.Items.Add("Bibliografia: " + p.GetBibliografia());
                    listBox4.Items.Add("Peliculas: ");
                    foreach(String a in basededatos.ObtenerPeliculasProducto(p))
                    {
                        listBox4.Items.Add(a);
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            comboBox4.Items.Clear();
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Persona p in basededatos.GetPersonas())
            {
                String nombre = p.GetNombre();
                comboBox5.Items.Add(nombre);
            }
            panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            panel6.BringToFront();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String nombre = comboBox5.Text;
            foreach (Estudio estudio in basededatos.GetEstudios())
            {
                if (estudio.GetNombre() == nombre)
                {
                    listBox5.Items.Add("Nombre: " + estudio.GetNombre());
                    listBox5.Items.Add("Direccion: " + estudio.GetDireccion());
                    listBox5.Items.Add("Fecha de apertura: " + estudio.GetApertura().ToString());
                    listBox5.Items.Add("Peliculas: ");
                    foreach(Pelicula p in basededatos.GetPeliculas())
                    {
                        if (estudio == p.GetEstudio())
                        {
                            listBox5.Items.Add(p.GetNombre());
                        }
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox5.Items.Clear();
            comboBox5.Items.Clear();
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.BringToFront();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (File.Exists("../../Serialize.txt"))
            {
                BinaryFormatter bin = new BinaryFormatter();
                Stream stream = new FileStream("../../Serialize.txt", FileMode.Open, FileAccess.Write);
                bin.Serialize(stream, basededatos);
                stream.Close();
            }
            else
            {
                BinaryFormatter bin = new BinaryFormatter();
                Stream stream = new FileStream("../../Serialize.txt", FileMode.Create, FileAccess.Write);
                bin.Serialize(stream, basededatos);
                stream.Close();
            }
            base.OnFormClosing(e);
        }
    }
}
