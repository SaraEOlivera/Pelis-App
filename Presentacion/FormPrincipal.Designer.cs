namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.pbxImagenPelis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPelis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToResizeColumns = false;
            this.dgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPeliculas.Location = new System.Drawing.Point(2, 12);
            this.dgvPeliculas.MultiSelect = false;
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeliculas.Size = new System.Drawing.Size(628, 224);
            this.dgvPeliculas.TabIndex = 0;
            this.dgvPeliculas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeliculas_CellDoubleClick);
            this.dgvPeliculas.SelectionChanged += new System.EventHandler(this.dgvPeliculas_SelectionChanged);
            // 
            // pbxImagenPelis
            // 
            this.pbxImagenPelis.Location = new System.Drawing.Point(668, 12);
            this.pbxImagenPelis.MaximumSize = new System.Drawing.Size(254, 224);
            this.pbxImagenPelis.MinimumSize = new System.Drawing.Size(254, 224);
            this.pbxImagenPelis.Name = "pbxImagenPelis";
            this.pbxImagenPelis.Size = new System.Drawing.Size(254, 224);
            this.pbxImagenPelis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenPelis.TabIndex = 1;
            this.pbxImagenPelis.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 261);
            this.Controls.Add(this.pbxImagenPelis);
            this.Controls.Add(this.dgvPeliculas);
            this.MaximumSize = new System.Drawing.Size(961, 300);
            this.MinimumSize = new System.Drawing.Size(961, 300);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peliculas";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPelis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.PictureBox pbxImagenPelis;
    }
}

