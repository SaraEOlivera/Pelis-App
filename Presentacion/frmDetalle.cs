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
    }
}
