namespace Presentacion
{
    partial class frmNuevaPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptarNuevaPeli = new System.Windows.Forms.Button();
            this.btnCancelarNuevaPeli = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.txtMinutoDuracion = new System.Windows.Forms.TextBox();
            this.txtFechaEstreno = new System.Windows.Forms.TextBox();
            this.txtBio = new System.Windows.Forms.TextBox();
            this.lblBio = new System.Windows.Forms.Label();
            this.pbxImagenPelis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPelis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptarNuevaPeli
            // 
            this.btnAceptarNuevaPeli.Location = new System.Drawing.Point(36, 327);
            this.btnAceptarNuevaPeli.Name = "btnAceptarNuevaPeli";
            this.btnAceptarNuevaPeli.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNuevaPeli.TabIndex = 0;
            this.btnAceptarNuevaPeli.Text = "&Aceptar";
            this.btnAceptarNuevaPeli.UseVisualStyleBackColor = true;
            this.btnAceptarNuevaPeli.Click += new System.EventHandler(this.btnAceptarNuevaPeli_Click);
            // 
            // btnCancelarNuevaPeli
            // 
            this.btnCancelarNuevaPeli.Location = new System.Drawing.Point(152, 327);
            this.btnCancelarNuevaPeli.Name = "btnCancelarNuevaPeli";
            this.btnCancelarNuevaPeli.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNuevaPeli.TabIndex = 1;
            this.btnCancelarNuevaPeli.Text = "&Cancelar";
            this.btnCancelarNuevaPeli.UseVisualStyleBackColor = true;
            this.btnCancelarNuevaPeli.Click += new System.EventHandler(this.btnCancelarNuevaPeli_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(36, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(19, 157);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(50, 13);
            this.lblDuracion.TabIndex = 4;
            this.lblDuracion.Text = "Duración";
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Location = new System.Drawing.Point(27, 117);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(42, 13);
            this.lblImagenUrl.TabIndex = 5;
            this.lblImagenUrl.Text = "Imagen";
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Location = new System.Drawing.Point(26, 77);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(43, 13);
            this.lblFechaEstreno.TabIndex = 6;
            this.lblFechaEstreno.Text = "Estreno";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(77, 35);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(291, 20);
            this.txtTitulo.TabIndex = 7;
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(75, 106);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(291, 20);
            this.txtImagenUrl.TabIndex = 8;
            // 
            // txtMinutoDuracion
            // 
            this.txtMinutoDuracion.Location = new System.Drawing.Point(75, 154);
            this.txtMinutoDuracion.Name = "txtMinutoDuracion";
            this.txtMinutoDuracion.Size = new System.Drawing.Size(291, 20);
            this.txtMinutoDuracion.TabIndex = 9;
            // 
            // txtFechaEstreno
            // 
            this.txtFechaEstreno.Location = new System.Drawing.Point(75, 67);
            this.txtFechaEstreno.Name = "txtFechaEstreno";
            this.txtFechaEstreno.Size = new System.Drawing.Size(291, 20);
            this.txtFechaEstreno.TabIndex = 10;
            // 
            // txtBio
            // 
            this.txtBio.Location = new System.Drawing.Point(75, 197);
            this.txtBio.Name = "txtBio";
            this.txtBio.Size = new System.Drawing.Size(291, 20);
            this.txtBio.TabIndex = 12;
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Location = new System.Drawing.Point(47, 197);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(22, 13);
            this.lblBio.TabIndex = 11;
            this.lblBio.Text = "Bio";
            // 
            // pbxImagenPelis
            // 
            this.pbxImagenPelis.Location = new System.Drawing.Point(372, 35);
            this.pbxImagenPelis.Name = "pbxImagenPelis";
            this.pbxImagenPelis.Size = new System.Drawing.Size(218, 182);
            this.pbxImagenPelis.TabIndex = 13;
            this.pbxImagenPelis.TabStop = false;
            // 
            // frmNuevaPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 375);
            this.Controls.Add(this.pbxImagenPelis);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.txtFechaEstreno);
            this.Controls.Add(this.txtMinutoDuracion);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblFechaEstreno);
            this.Controls.Add(this.lblImagenUrl);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelarNuevaPeli);
            this.Controls.Add(this.btnAceptarNuevaPeli);
            this.Name = "frmNuevaPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Película";
            this.Load += new System.EventHandler(this.frmNuevaPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenPelis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptarNuevaPeli;
        private System.Windows.Forms.Button btnCancelarNuevaPeli;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.TextBox txtMinutoDuracion;
        private System.Windows.Forms.TextBox txtFechaEstreno;
        private System.Windows.Forms.TextBox txtBio;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.PictureBox pbxImagenPelis;
    }
}