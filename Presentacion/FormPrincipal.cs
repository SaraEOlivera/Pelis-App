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
using Negocio;


namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        private List<Pelicula> listaPeliculas;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region Load
            private void FormPrincipal_Load(object sender, EventArgs e)
            {
                PelisNegocio negocio = new PelisNegocio();
                listaPeliculas = negocio.listar();
                dgvPeliculas.DataSource = listaPeliculas;
                cargarImagen(listaPeliculas[0].Media.MediaURL);
                ocultarColumnas();
            }
        #endregion

        #region OcultarColumnas
        public void ocultarColumnas()
        {
            dgvPeliculas.Columns["Bio"].Visible = false;
            dgvPeliculas.Columns["Duracion"].Visible = false;
            dgvPeliculas.Columns["Media"].Visible = false;
        }
        #endregion

        private void dgvPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            Pelicula seleccionado = (Pelicula)dgvPeliculas.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Media.MediaURL);
        }

        private void cargarImagen(string imagen) 
        {
            try
            {
                pbxImagenPelis.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagenPelis.Load("https://media.istockphoto.com/id/2170017549/vector/curved-film-strip-icon-empty-frame-design-black-border-vector-cinematic-template-element.jpg?s=612x612&w=0&k=20&c=wywajhKcxUCwjjFElamrHf2wxSq-ThsnwVlI4-yhX1Y=");
            }
        }

        private void dgvPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
