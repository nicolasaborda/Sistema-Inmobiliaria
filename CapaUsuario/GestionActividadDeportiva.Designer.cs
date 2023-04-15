
namespace CapaUsuario
{
    partial class GestionActividadDeportiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionActividadDeportiva));
            this.listBox1_ActividadesDeportivas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gestActDep_botonCrear = new System.Windows.Forms.Button();
            this.gestActDep_botonModif = new System.Windows.Forms.Button();
            this.gestActDep_botonEliminar = new System.Windows.Forms.Button();
            this.gestActDep_botonCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1_ActividadesDeportivas
            // 
            this.listBox1_ActividadesDeportivas.FormattingEnabled = true;
            this.listBox1_ActividadesDeportivas.HorizontalScrollbar = true;
            this.listBox1_ActividadesDeportivas.ItemHeight = 15;
            this.listBox1_ActividadesDeportivas.Location = new System.Drawing.Point(8, 48);
            this.listBox1_ActividadesDeportivas.Name = "listBox1_ActividadesDeportivas";
            this.listBox1_ActividadesDeportivas.ScrollAlwaysVisible = true;
            this.listBox1_ActividadesDeportivas.Size = new System.Drawing.Size(336, 304);
            this.listBox1_ActividadesDeportivas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de actividades disponibles.";
            // 
            // gestActDep_botonCrear
            // 
            this.gestActDep_botonCrear.Location = new System.Drawing.Point(7, 372);
            this.gestActDep_botonCrear.Name = "gestActDep_botonCrear";
            this.gestActDep_botonCrear.Size = new System.Drawing.Size(75, 23);
            this.gestActDep_botonCrear.TabIndex = 2;
            this.gestActDep_botonCrear.Text = "Agregar";
            this.gestActDep_botonCrear.UseVisualStyleBackColor = true;
            this.gestActDep_botonCrear.Click += new System.EventHandler(this.gestActDep_botonCrear_Click);
            // 
            // gestActDep_botonModif
            // 
            this.gestActDep_botonModif.Location = new System.Drawing.Point(135, 372);
            this.gestActDep_botonModif.Name = "gestActDep_botonModif";
            this.gestActDep_botonModif.Size = new System.Drawing.Size(75, 23);
            this.gestActDep_botonModif.TabIndex = 3;
            this.gestActDep_botonModif.Text = "Modificar";
            this.gestActDep_botonModif.UseVisualStyleBackColor = true;
            this.gestActDep_botonModif.Click += new System.EventHandler(this.gestActDep_botonModif_Click);
            // 
            // gestActDep_botonEliminar
            // 
            this.gestActDep_botonEliminar.Location = new System.Drawing.Point(271, 372);
            this.gestActDep_botonEliminar.Name = "gestActDep_botonEliminar";
            this.gestActDep_botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.gestActDep_botonEliminar.TabIndex = 4;
            this.gestActDep_botonEliminar.Text = "Eliminar";
            this.gestActDep_botonEliminar.UseVisualStyleBackColor = true;
            this.gestActDep_botonEliminar.Click += new System.EventHandler(this.gestActDep_botonEliminar_Click);
            // 
            // gestActDep_botonCerrar
            // 
            this.gestActDep_botonCerrar.Location = new System.Drawing.Point(135, 419);
            this.gestActDep_botonCerrar.Name = "gestActDep_botonCerrar";
            this.gestActDep_botonCerrar.Size = new System.Drawing.Size(75, 23);
            this.gestActDep_botonCerrar.TabIndex = 5;
            this.gestActDep_botonCerrar.Text = "Volver atrás";
            this.gestActDep_botonCerrar.UseVisualStyleBackColor = true;
            this.gestActDep_botonCerrar.Click += new System.EventHandler(this.gestActDep_botonCerrar_Click);
            // 
            // GestionActividadDeportiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 485);
            this.Controls.Add(this.gestActDep_botonCerrar);
            this.Controls.Add(this.gestActDep_botonEliminar);
            this.Controls.Add(this.gestActDep_botonModif);
            this.Controls.Add(this.gestActDep_botonCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1_ActividadesDeportivas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 40);
            this.Name = "GestionActividadDeportiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1_ActividadesDeportivas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gestActDep_botonCrear;
        private System.Windows.Forms.Button gestActDep_botonModif;
        private System.Windows.Forms.Button gestActDep_botonEliminar;
        private System.Windows.Forms.Button gestActDep_botonCerrar;
    }
}