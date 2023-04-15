
namespace CapaUsuario
{
    partial class GestionSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionSocio));
            this.gestSocio_botonCerrar = new System.Windows.Forms.Button();
            this.gestSocio_botonEliminar = new System.Windows.Forms.Button();
            this.gestSocio_botonModif = new System.Windows.Forms.Button();
            this.gestSocio_botonCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_Socios = new System.Windows.Forms.ListBox();
            this.gestSocio_botonActivo = new System.Windows.Forms.Button();
            this.gestSocio_botonInactivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gestSocio_botonCerrar
            // 
            this.gestSocio_botonCerrar.Location = new System.Drawing.Point(269, 450);
            this.gestSocio_botonCerrar.Name = "gestSocio_botonCerrar";
            this.gestSocio_botonCerrar.Size = new System.Drawing.Size(75, 23);
            this.gestSocio_botonCerrar.TabIndex = 11;
            this.gestSocio_botonCerrar.Text = "Cerrar";
            this.gestSocio_botonCerrar.UseVisualStyleBackColor = true;
            this.gestSocio_botonCerrar.Click += new System.EventHandler(this.gestSocio_botonCerrar_Click);
            // 
            // gestSocio_botonEliminar
            // 
            this.gestSocio_botonEliminar.Location = new System.Drawing.Point(269, 400);
            this.gestSocio_botonEliminar.Name = "gestSocio_botonEliminar";
            this.gestSocio_botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.gestSocio_botonEliminar.TabIndex = 10;
            this.gestSocio_botonEliminar.Text = "Eliminar";
            this.gestSocio_botonEliminar.UseVisualStyleBackColor = true;
            this.gestSocio_botonEliminar.Click += new System.EventHandler(this.gestSocio_botonEliminar_Click);
            // 
            // gestSocio_botonModif
            // 
            this.gestSocio_botonModif.Location = new System.Drawing.Point(136, 400);
            this.gestSocio_botonModif.Name = "gestSocio_botonModif";
            this.gestSocio_botonModif.Size = new System.Drawing.Size(75, 23);
            this.gestSocio_botonModif.TabIndex = 9;
            this.gestSocio_botonModif.Text = "Modificar";
            this.gestSocio_botonModif.UseVisualStyleBackColor = true;
            this.gestSocio_botonModif.Click += new System.EventHandler(this.gestSocio_botonModif_Click);
            // 
            // gestSocio_botonCrear
            // 
            this.gestSocio_botonCrear.Location = new System.Drawing.Point(8, 400);
            this.gestSocio_botonCrear.Name = "gestSocio_botonCrear";
            this.gestSocio_botonCrear.Size = new System.Drawing.Size(75, 23);
            this.gestSocio_botonCrear.TabIndex = 8;
            this.gestSocio_botonCrear.Text = "Crear";
            this.gestSocio_botonCrear.UseVisualStyleBackColor = true;
            this.gestSocio_botonCrear.Click += new System.EventHandler(this.gestSocio_botonCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione el Socio que desea Modificar o Eliminar. \r\nSi desea crear un nuevo Soc" +
    "io, use Crear.";
            // 
            // listBox1_Socios
            // 
            this.listBox1_Socios.FormattingEnabled = true;
            this.listBox1_Socios.HorizontalScrollbar = true;
            this.listBox1_Socios.ItemHeight = 15;
            this.listBox1_Socios.Location = new System.Drawing.Point(8, 48);
            this.listBox1_Socios.Name = "listBox1_Socios";
            this.listBox1_Socios.ScrollAlwaysVisible = true;
            this.listBox1_Socios.Size = new System.Drawing.Size(336, 319);
            this.listBox1_Socios.TabIndex = 6;
            // 
            // gestSocio_botonActivo
            // 
            this.gestSocio_botonActivo.BackColor = System.Drawing.Color.LightGreen;
            this.gestSocio_botonActivo.Location = new System.Drawing.Point(8, 450);
            this.gestSocio_botonActivo.Name = "gestSocio_botonActivo";
            this.gestSocio_botonActivo.Size = new System.Drawing.Size(75, 23);
            this.gestSocio_botonActivo.TabIndex = 12;
            this.gestSocio_botonActivo.Text = "Activo";
            this.gestSocio_botonActivo.UseVisualStyleBackColor = false;
            this.gestSocio_botonActivo.Click += new System.EventHandler(this.gestSocio_botonActivo_Click);
            // 
            // gestSocio_botonInactivo
            // 
            this.gestSocio_botonInactivo.BackColor = System.Drawing.Color.Coral;
            this.gestSocio_botonInactivo.Location = new System.Drawing.Point(136, 450);
            this.gestSocio_botonInactivo.Name = "gestSocio_botonInactivo";
            this.gestSocio_botonInactivo.Size = new System.Drawing.Size(75, 23);
            this.gestSocio_botonInactivo.TabIndex = 13;
            this.gestSocio_botonInactivo.Text = "Inactivo";
            this.gestSocio_botonInactivo.UseVisualStyleBackColor = false;
            this.gestSocio_botonInactivo.Click += new System.EventHandler(this.gestSocio_botonInactivo_Click);
            // 
            // GestionSocio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(360, 485);
            this.Controls.Add(this.gestSocio_botonInactivo);
            this.Controls.Add(this.gestSocio_botonActivo);
            this.Controls.Add(this.gestSocio_botonCerrar);
            this.Controls.Add(this.gestSocio_botonEliminar);
            this.Controls.Add(this.gestSocio_botonModif);
            this.Controls.Add(this.gestSocio_botonCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1_Socios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(350, 75);
            this.Name = "GestionSocio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GestionSocio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gestSocio_botonCerrar;
        private System.Windows.Forms.Button gestSocio_botonEliminar;
        private System.Windows.Forms.Button gestSocio_botonModif;
        private System.Windows.Forms.Button gestSocio_botonCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1_Socios;
        private System.Windows.Forms.Button gestSocio_botonActivo;
        private System.Windows.Forms.Button gestSocio_botonInactivo;
    }
}