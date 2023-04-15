
namespace CapaUsuario
{
    partial class GestionClase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClase));
            this.gestionClase_botonInscribirSocio = new System.Windows.Forms.Button();
            this.gestClase_botonCerrar = new System.Windows.Forms.Button();
            this.gestClase_botonEliminar = new System.Windows.Forms.Button();
            this.gestClase_botonModif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_Clases = new System.Windows.Forms.ListBox();
            this.gestionClase_botonAgregarClaseNueva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gestionClase_botonInscribirSocio
            // 
            this.gestionClase_botonInscribirSocio.Location = new System.Drawing.Point(174, 382);
            this.gestionClase_botonInscribirSocio.Name = "gestionClase_botonInscribirSocio";
            this.gestionClase_botonInscribirSocio.Size = new System.Drawing.Size(75, 24);
            this.gestionClase_botonInscribirSocio.TabIndex = 13;
            this.gestionClase_botonInscribirSocio.Text = "Gestionar";
            this.gestionClase_botonInscribirSocio.UseVisualStyleBackColor = true;
            this.gestionClase_botonInscribirSocio.Click += new System.EventHandler(this.gestionClase_botonInscribirSocio_Click);
            // 
            // gestClase_botonCerrar
            // 
            this.gestClase_botonCerrar.Location = new System.Drawing.Point(126, 436);
            this.gestClase_botonCerrar.Name = "gestClase_botonCerrar";
            this.gestClase_botonCerrar.Size = new System.Drawing.Size(75, 23);
            this.gestClase_botonCerrar.TabIndex = 12;
            this.gestClase_botonCerrar.Text = "Volver atrás";
            this.gestClase_botonCerrar.UseVisualStyleBackColor = true;
            this.gestClase_botonCerrar.Click += new System.EventHandler(this.gestClase_botonCerrar_Click);
            // 
            // gestClase_botonEliminar
            // 
            this.gestClase_botonEliminar.Location = new System.Drawing.Point(255, 383);
            this.gestClase_botonEliminar.Name = "gestClase_botonEliminar";
            this.gestClase_botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.gestClase_botonEliminar.TabIndex = 11;
            this.gestClase_botonEliminar.Text = "Eliminar";
            this.gestClase_botonEliminar.UseVisualStyleBackColor = true;
            this.gestClase_botonEliminar.Click += new System.EventHandler(this.gestClase_botonEliminar_Click);
            // 
            // gestClase_botonModif
            // 
            this.gestClase_botonModif.Location = new System.Drawing.Point(93, 383);
            this.gestClase_botonModif.Name = "gestClase_botonModif";
            this.gestClase_botonModif.Size = new System.Drawing.Size(75, 23);
            this.gestClase_botonModif.TabIndex = 10;
            this.gestClase_botonModif.Text = "Modificar";
            this.gestClase_botonModif.UseVisualStyleBackColor = true;
            this.gestClase_botonModif.Click += new System.EventHandler(this.gestClase_botonModif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Listado de clases disponibles.";
            // 
            // listBox1_Clases
            // 
            this.listBox1_Clases.FormattingEnabled = true;
            this.listBox1_Clases.HorizontalScrollbar = true;
            this.listBox1_Clases.ItemHeight = 15;
            this.listBox1_Clases.Location = new System.Drawing.Point(8, 48);
            this.listBox1_Clases.Name = "listBox1_Clases";
            this.listBox1_Clases.ScrollAlwaysVisible = true;
            this.listBox1_Clases.Size = new System.Drawing.Size(331, 304);
            this.listBox1_Clases.TabIndex = 7;
            // 
            // gestionClase_botonAgregarClaseNueva
            // 
            this.gestionClase_botonAgregarClaseNueva.Location = new System.Drawing.Point(12, 383);
            this.gestionClase_botonAgregarClaseNueva.Name = "gestionClase_botonAgregarClaseNueva";
            this.gestionClase_botonAgregarClaseNueva.Size = new System.Drawing.Size(75, 23);
            this.gestionClase_botonAgregarClaseNueva.TabIndex = 14;
            this.gestionClase_botonAgregarClaseNueva.Text = "Agregar";
            this.gestionClase_botonAgregarClaseNueva.UseVisualStyleBackColor = true;
            this.gestionClase_botonAgregarClaseNueva.Click += new System.EventHandler(this.gestionClase_botonAgregarClaseNueva_Click);
            // 
            // GestionClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 485);
            this.Controls.Add(this.gestionClase_botonAgregarClaseNueva);
            this.Controls.Add(this.gestionClase_botonInscribirSocio);
            this.Controls.Add(this.gestClase_botonCerrar);
            this.Controls.Add(this.gestClase_botonEliminar);
            this.Controls.Add(this.gestClase_botonModif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1_Clases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GestionClase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gestionClase_botonInscribirSocio;
        private System.Windows.Forms.Button gestClase_botonCerrar;
        private System.Windows.Forms.Button gestClase_botonEliminar;
        private System.Windows.Forms.Button gestClase_botonModif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1_Clases;
        private System.Windows.Forms.Button gestionClase_botonAgregarClaseNueva;
    }
}