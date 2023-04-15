
namespace CapaUsuario
{
    partial class GestionProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionProfesor));
            this.gestProfesor_botonCerrar = new System.Windows.Forms.Button();
            this.gestProfesor_botonEliminar = new System.Windows.Forms.Button();
            this.gestProfesor_botonModif = new System.Windows.Forms.Button();
            this.gestProfesor_botonCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_Profesor = new System.Windows.Forms.ListBox();
            this.gestProfesor_botonActivo = new System.Windows.Forms.Button();
            this.gestProfesor_botonInactivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gestProfesor_botonCerrar
            // 
            this.gestProfesor_botonCerrar.Location = new System.Drawing.Point(269, 443);
            this.gestProfesor_botonCerrar.Name = "gestProfesor_botonCerrar";
            this.gestProfesor_botonCerrar.Size = new System.Drawing.Size(75, 23);
            this.gestProfesor_botonCerrar.TabIndex = 17;
            this.gestProfesor_botonCerrar.Text = "Volver atrás";
            this.gestProfesor_botonCerrar.UseVisualStyleBackColor = true;
            this.gestProfesor_botonCerrar.Click += new System.EventHandler(this.gestProfesor_botonCerrar_Click);
            // 
            // gestProfesor_botonEliminar
            // 
            this.gestProfesor_botonEliminar.Location = new System.Drawing.Point(269, 400);
            this.gestProfesor_botonEliminar.Name = "gestProfesor_botonEliminar";
            this.gestProfesor_botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.gestProfesor_botonEliminar.TabIndex = 16;
            this.gestProfesor_botonEliminar.Text = "Eliminar";
            this.gestProfesor_botonEliminar.UseVisualStyleBackColor = true;
            this.gestProfesor_botonEliminar.Click += new System.EventHandler(this.gestProfesor_botonEliminar_Click);
            // 
            // gestProfesor_botonModif
            // 
            this.gestProfesor_botonModif.Location = new System.Drawing.Point(136, 400);
            this.gestProfesor_botonModif.Name = "gestProfesor_botonModif";
            this.gestProfesor_botonModif.Size = new System.Drawing.Size(75, 23);
            this.gestProfesor_botonModif.TabIndex = 15;
            this.gestProfesor_botonModif.Text = "Modificar";
            this.gestProfesor_botonModif.UseVisualStyleBackColor = true;
            this.gestProfesor_botonModif.Click += new System.EventHandler(this.gestProfesor_botonModif_Click);
            // 
            // gestProfesor_botonCrear
            // 
            this.gestProfesor_botonCrear.Location = new System.Drawing.Point(13, 400);
            this.gestProfesor_botonCrear.Name = "gestProfesor_botonCrear";
            this.gestProfesor_botonCrear.Size = new System.Drawing.Size(75, 23);
            this.gestProfesor_botonCrear.TabIndex = 14;
            this.gestProfesor_botonCrear.Text = "Agregar";
            this.gestProfesor_botonCrear.UseVisualStyleBackColor = true;
            this.gestProfesor_botonCrear.Click += new System.EventHandler(this.gestProfesor_botonCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Listado de profesores disponibles.";
            // 
            // listBox1_Profesor
            // 
            this.listBox1_Profesor.FormattingEnabled = true;
            this.listBox1_Profesor.HorizontalScrollbar = true;
            this.listBox1_Profesor.ItemHeight = 15;
            this.listBox1_Profesor.Location = new System.Drawing.Point(8, 48);
            this.listBox1_Profesor.Name = "listBox1_Profesor";
            this.listBox1_Profesor.ScrollAlwaysVisible = true;
            this.listBox1_Profesor.Size = new System.Drawing.Size(336, 319);
            this.listBox1_Profesor.TabIndex = 12;
            // 
            // gestProfesor_botonActivo
            // 
            this.gestProfesor_botonActivo.BackColor = System.Drawing.Color.LightGreen;
            this.gestProfesor_botonActivo.Location = new System.Drawing.Point(13, 442);
            this.gestProfesor_botonActivo.Name = "gestProfesor_botonActivo";
            this.gestProfesor_botonActivo.Size = new System.Drawing.Size(75, 23);
            this.gestProfesor_botonActivo.TabIndex = 18;
            this.gestProfesor_botonActivo.Text = "Activo";
            this.gestProfesor_botonActivo.UseVisualStyleBackColor = false;
            this.gestProfesor_botonActivo.Click += new System.EventHandler(this.gestProfesor_botonActivo_Click);
            // 
            // gestProfesor_botonInactivo
            // 
            this.gestProfesor_botonInactivo.BackColor = System.Drawing.Color.Coral;
            this.gestProfesor_botonInactivo.Location = new System.Drawing.Point(136, 442);
            this.gestProfesor_botonInactivo.Name = "gestProfesor_botonInactivo";
            this.gestProfesor_botonInactivo.Size = new System.Drawing.Size(75, 23);
            this.gestProfesor_botonInactivo.TabIndex = 19;
            this.gestProfesor_botonInactivo.Text = "Inactivo";
            this.gestProfesor_botonInactivo.UseVisualStyleBackColor = false;
            this.gestProfesor_botonInactivo.Click += new System.EventHandler(this.gestProfesor_botonInactivo_Click);
            // 
            // GestionProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 485);
            this.Controls.Add(this.gestProfesor_botonInactivo);
            this.Controls.Add(this.gestProfesor_botonActivo);
            this.Controls.Add(this.gestProfesor_botonCerrar);
            this.Controls.Add(this.gestProfesor_botonEliminar);
            this.Controls.Add(this.gestProfesor_botonModif);
            this.Controls.Add(this.gestProfesor_botonCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1_Profesor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionProfesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button gestProfesor_botonCerrar;
        private System.Windows.Forms.Button gestProfesor_botonEliminar;
        private System.Windows.Forms.Button gestProfesor_botonModif;
        private System.Windows.Forms.Button gestProfesor_botonCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1_Profesor;
        #endregion

        private System.Windows.Forms.Button gestProfesor_botonActivo;
        private System.Windows.Forms.Button gestProfesor_botonInactivo;
    }
}