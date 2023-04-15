
namespace CapaUsuario
{
    partial class InscribirSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscribirSocio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1_Socios = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inscribirSocio_botonDesinscribir = new System.Windows.Forms.Button();
            this.inscribirSocio_botonInscribir = new System.Windows.Forms.Button();
            this.listBox2_Inscriptos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inscribirSocio_botonCerrar = new System.Windows.Forms.Button();
            this.inscribirSocio_textBoxAD = new System.Windows.Forms.TextBox();
            this.inscribirSocio_textBoxClase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actividad Deportiva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clase";
            // 
            // listBox1_Socios
            // 
            this.listBox1_Socios.FormattingEnabled = true;
            this.listBox1_Socios.HorizontalScrollbar = true;
            this.listBox1_Socios.ItemHeight = 15;
            this.listBox1_Socios.Location = new System.Drawing.Point(12, 205);
            this.listBox1_Socios.Name = "listBox1_Socios";
            this.listBox1_Socios.ScrollAlwaysVisible = true;
            this.listBox1_Socios.Size = new System.Drawing.Size(144, 94);
            this.listBox1_Socios.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lista de Socios del Club";
            // 
            // inscribirSocio_botonDesinscribir
            // 
            this.inscribirSocio_botonDesinscribir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.inscribirSocio_botonDesinscribir.Location = new System.Drawing.Point(164, 245);
            this.inscribirSocio_botonDesinscribir.Name = "inscribirSocio_botonDesinscribir";
            this.inscribirSocio_botonDesinscribir.Size = new System.Drawing.Size(48, 23);
            this.inscribirSocio_botonDesinscribir.TabIndex = 9;
            this.inscribirSocio_botonDesinscribir.Text = "<--";
            this.inscribirSocio_botonDesinscribir.UseVisualStyleBackColor = false;
            this.inscribirSocio_botonDesinscribir.Click += new System.EventHandler(this.inscribirSocio_botonDesinscribir_Click);
            // 
            // inscribirSocio_botonInscribir
            // 
            this.inscribirSocio_botonInscribir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.inscribirSocio_botonInscribir.Location = new System.Drawing.Point(164, 213);
            this.inscribirSocio_botonInscribir.Name = "inscribirSocio_botonInscribir";
            this.inscribirSocio_botonInscribir.Size = new System.Drawing.Size(48, 23);
            this.inscribirSocio_botonInscribir.TabIndex = 10;
            this.inscribirSocio_botonInscribir.Text = "-->";
            this.inscribirSocio_botonInscribir.UseVisualStyleBackColor = false;
            this.inscribirSocio_botonInscribir.Click += new System.EventHandler(this.inscribirSocio_botonInscribir_Click);
            // 
            // listBox2_Inscriptos
            // 
            this.listBox2_Inscriptos.FormattingEnabled = true;
            this.listBox2_Inscriptos.HorizontalScrollbar = true;
            this.listBox2_Inscriptos.ItemHeight = 15;
            this.listBox2_Inscriptos.Location = new System.Drawing.Point(220, 205);
            this.listBox2_Inscriptos.Name = "listBox2_Inscriptos";
            this.listBox2_Inscriptos.ScrollAlwaysVisible = true;
            this.listBox2_Inscriptos.Size = new System.Drawing.Size(144, 94);
            this.listBox2_Inscriptos.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lista de Socios Inscriptos";
            // 
            // inscribirSocio_botonCerrar
            // 
            this.inscribirSocio_botonCerrar.Location = new System.Drawing.Point(148, 317);
            this.inscribirSocio_botonCerrar.Name = "inscribirSocio_botonCerrar";
            this.inscribirSocio_botonCerrar.Size = new System.Drawing.Size(75, 23);
            this.inscribirSocio_botonCerrar.TabIndex = 13;
            this.inscribirSocio_botonCerrar.Text = "Volver atrás";
            this.inscribirSocio_botonCerrar.UseVisualStyleBackColor = true;
            this.inscribirSocio_botonCerrar.Click += new System.EventHandler(this.inscribirSocio_botonCerrar_Click);
            // 
            // inscribirSocio_textBoxAD
            // 
            this.inscribirSocio_textBoxAD.Location = new System.Drawing.Point(12, 69);
            this.inscribirSocio_textBoxAD.Name = "inscribirSocio_textBoxAD";
            this.inscribirSocio_textBoxAD.Size = new System.Drawing.Size(352, 23);
            this.inscribirSocio_textBoxAD.TabIndex = 14;
            // 
            // inscribirSocio_textBoxClase
            // 
            this.inscribirSocio_textBoxClase.Location = new System.Drawing.Point(12, 144);
            this.inscribirSocio_textBoxClase.Name = "inscribirSocio_textBoxClase";
            this.inscribirSocio_textBoxClase.Size = new System.Drawing.Size(352, 23);
            this.inscribirSocio_textBoxClase.TabIndex = 15;
            // 
            // InscribirSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 391);
            this.Controls.Add(this.inscribirSocio_textBoxClase);
            this.Controls.Add(this.inscribirSocio_textBoxAD);
            this.Controls.Add(this.inscribirSocio_botonCerrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2_Inscriptos);
            this.Controls.Add(this.inscribirSocio_botonInscribir);
            this.Controls.Add(this.inscribirSocio_botonDesinscribir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1_Socios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InscribirSocio";
            this.Text = "Inscribir Socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1_Socios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button inscribirSocio_botonDesinscribir;
        private System.Windows.Forms.Button inscribirSocio_botonInscribir;
        private System.Windows.Forms.ListBox listBox2_Inscriptos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button inscribirSocio_botonCerrar;
        private System.Windows.Forms.TextBox inscribirSocio_textBoxAD;
        private System.Windows.Forms.TextBox inscribirSocio_textBoxClase;
    }
}