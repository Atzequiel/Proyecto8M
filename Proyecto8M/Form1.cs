using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto8M
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }

        private void cmbPefil_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = (cmbPefil.SelectedIndex + 1).ToString();
            mostrarDatos(id);
            mostrarImagen(id);
        }

        private void mostrarDatos(String id)
        {
            string[] datos = new string[5];
            datos = Clases.Logica.getPerfil(id);

            lblId.Text = id;
            lblFecha.Text = datos[1];
            lblNacionalidad.Text = datos[2];
            lblOcupacion.Text = datos[3];
            lblLogro.Text = datos[4];
        }
        
        private void mostrarImagen(String id)
        {
            //string imagen = Clases.Logica.getImagen(id);
            //C: \Users\Administrator\source\repos\Proyecto8M\Proyecto8M\bin\Debug

            Console.WriteLine(id);
            Image imagen = Clases.Logica.getImagen(id);
            pcbFoto.Image = imagen;
        }

        private void btnPromedioEdades_Click(object sender, EventArgs e)
        {
            string nacionalidad = cmbNacionalidad.SelectedItem.ToString();
            double pe = Clases.Consultas.getPromedioEdades(nacionalidad);
            if (pe != 0)
            {
                MessageBox.Show($"El promedio de nacionalidades {nacionalidad} es: " + pe.ToString("0.0"));
            }
        }
    }
}