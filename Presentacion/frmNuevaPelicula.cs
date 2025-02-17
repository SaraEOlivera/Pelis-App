using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class frmNuevaPelicula : Form
    {
        public frmNuevaPelicula()
        {
            InitializeComponent();
        }

        private void frmNuevaPelicula_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarNuevaPeli_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarNuevaPeli_Click(object sender, EventArgs e)
        {
            Pelicula nuevaPelicula = new Pelicula();
            try
            {
                nuevaPelicula.Titulo = txtTitulo.Text;
                //nuevaPelicula.FechaEstreno = txtFechaEstreno.Text;
                //nuevaPelicula.Media.MediaURL = txtImagenUrl.Text;
                nuevaPelicula.Duracion = int.Parse(txtMinutoDuracion.Text);
                nuevaPelicula.Bio = txtBio.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
