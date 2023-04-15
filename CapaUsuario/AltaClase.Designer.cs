
namespace CapaUsuario
{
    partial class AltaClase
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaClase));
            this.altaSocio_botonSalir = new System.Windows.Forms.Button();
            this.altaSocio_botonGrabar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.altaClase_boxHorario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.altaClase_comboBoxProfesores = new System.Windows.Forms.ComboBox();
            this.altaClase_comboBoxActDeportiva = new System.Windows.Forms.ComboBox();
            this.altaClase_comboBoxDia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // altaSocio_botonSalir
            // 
            this.altaSocio_botonSalir.Location = new System.Drawing.Point(32, 284);
            this.altaSocio_botonSalir.Name = "altaSocio_botonSalir";
            this.altaSocio_botonSalir.Size = new System.Drawing.Size(72, 24);
            this.altaSocio_botonSalir.TabIndex = 44;
            this.altaSocio_botonSalir.Text = "Cancelar";
            this.altaSocio_botonSalir.UseVisualStyleBackColor = true;
            this.altaSocio_botonSalir.Click += new System.EventHandler(this.altaClase_botonSalir_Click_1);
            // 
            // altaSocio_botonGrabar
            // 
            this.altaSocio_botonGrabar.Location = new System.Drawing.Point(203, 285);
            this.altaSocio_botonGrabar.Name = "altaSocio_botonGrabar";
            this.altaSocio_botonGrabar.Size = new System.Drawing.Size(75, 23);
            this.altaSocio_botonGrabar.TabIndex = 43;
            this.altaSocio_botonGrabar.Text = "Agregar";
            this.altaSocio_botonGrabar.UseVisualStyleBackColor = true;
            this.altaSocio_botonGrabar.Click += new System.EventHandler(this.altaClase_botonGrabar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Horario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Día:";
            // 
            // altaClase_boxHorario
            // 
            this.altaClase_boxHorario.Location = new System.Drawing.Point(121, 104);
            this.altaClase_boxHorario.Name = "altaClase_boxHorario";
            this.altaClase_boxHorario.Size = new System.Drawing.Size(179, 23);
            this.altaClase_boxHorario.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Actividad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Profesor:";
            // 
            // altaClase_comboBoxProfesores
            // 
            this.altaClase_comboBoxProfesores.FormattingEnabled = true;
            this.altaClase_comboBoxProfesores.Location = new System.Drawing.Point(121, 219);
            this.altaClase_comboBoxProfesores.Name = "altaClase_comboBoxProfesores";
            this.altaClase_comboBoxProfesores.Size = new System.Drawing.Size(179, 23);
            this.altaClase_comboBoxProfesores.TabIndex = 50;
            // 
            // altaClase_comboBoxActDeportiva
            // 
            this.altaClase_comboBoxActDeportiva.FormattingEnabled = true;
            this.altaClase_comboBoxActDeportiva.Location = new System.Drawing.Point(121, 159);
            this.altaClase_comboBoxActDeportiva.Name = "altaClase_comboBoxActDeportiva";
            this.altaClase_comboBoxActDeportiva.Size = new System.Drawing.Size(179, 23);
            this.altaClase_comboBoxActDeportiva.TabIndex = 51;
            // 
            // altaClase_comboBoxDia
            // 
            this.altaClase_comboBoxDia.FormattingEnabled = true;
            this.altaClase_comboBoxDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.altaClase_comboBoxDia.Location = new System.Drawing.Point(121, 46);
            this.altaClase_comboBoxDia.Name = "altaClase_comboBoxDia";
            this.altaClase_comboBoxDia.Size = new System.Drawing.Size(179, 23);
            this.altaClase_comboBoxDia.TabIndex = 52;
            // 
            // AltaClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 339);
            this.Controls.Add(this.altaClase_comboBoxDia);
            this.Controls.Add(this.altaClase_comboBoxActDeportiva);
            this.Controls.Add(this.altaClase_comboBoxProfesores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.altaSocio_botonSalir);
            this.Controls.Add(this.altaSocio_botonGrabar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altaClase_boxHorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AltaClase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Clase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button altaSocio_botonSalir;
        private System.Windows.Forms.Button altaSocio_botonGrabar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox altaClase_boxHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox altaClase_comboBoxProfesores;
        private System.Windows.Forms.ComboBox altaClase_comboBoxActDeportiva;
        private System.Windows.Forms.ComboBox altaClase_comboBoxDia;
    }
}