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
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            PelisNegocio negocio = new PelisNegocio();
            dgvPeliculas.DataSource = negocio.listar();
            ocultarColumnas();
        }

        public void ocultarColumnas()
        {
            dgvPeliculas.Columns["Bio"].Visible = false;
            dgvPeliculas.Columns["Duracion"].Visible = false;


        }
    }
}
