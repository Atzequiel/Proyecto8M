using System;
using System.Drawing;
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
            int id = cmbPefil.SelectedIndex + 1;
            mostrarDatos(id);
            mostrarImagen(id);
        }

        private void mostrarDatos(int id)
        {
            string[] datos = Clases.Logica.getPerfil(id);

            lblId.Text = $"ID: {id}";
            lblFecha.Text = datos[1];
            lblNacionalidad.Text = datos[2];
            lblOcupacion.Text = datos[3];
            lblLogro.Text = datos[4];
        }

        private void mostrarImagen(int id)
        {
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
                _ = MessageBox.Show($"El promedio de nacionalidades {nacionalidad} es: " + pe.ToString("0.0"));
            }
        }
    }
}