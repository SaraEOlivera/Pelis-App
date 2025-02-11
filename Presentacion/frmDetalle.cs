using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmDetalle : Form
    {
        private Pelicula seleccionada;
        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Pelicula pelicula)
        {
            InitializeComponent();
            this.seleccionada = pelicula;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            txtTituloDetalle.Text = seleccionada.Titulo;
            txtBioDetalle.Text = seleccionada.Bio;
            txtEstrenoDetalle.Text = seleccionada.FechaEstreno.HasValue ? seleccionada.FechaEstreno.Value.ToString("dd/MM/yyyy") : "Sin info sobre la fecha de estreno";
            txtDuracionDetalle.Text = seleccionada.Duracion.ToString();
            //txtRepartoDetalle.Text = seleccionada.Reparto.Descripcion;
            //txtPlataformasDetalle.Text = seleccionada.Plataformas.Descripcion;
            if (!string.IsNullOrEmpty(seleccionada.Media.MediaURL)) 
            {
                try
                {
                    pbxDetalle.Load(seleccionada.Media.MediaURL);
                }
                catch (Exception)
                {
                    pbxDetalle.Load("https://media.istockphoto.com/id/2170017549/vector/curved-film-strip-icon-empty-frame-design-black-border-vector-cinematic-template-element.jpg?s=612x612&w=0&k=20&c=wywajhKcxUCwjjFElamrHf2wxSq-ThsnwVlI4-yhX1Y=");
                }
            }
        }
    }
}
