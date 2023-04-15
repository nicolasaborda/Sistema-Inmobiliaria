
namespace CapaUsuario
{
    partial class ModificarClase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarClase));
            this.modificarClase_comboBoxDia = new System.Windows.Forms.ComboBox();
            this.modificarClase_comboBoxProfesor = new System.Windows.Forms.ComboBox();
            this.modificarClase_buttonCerrar = new System.Windows.Forms.Button();
            this.modificarClase_buttonGuardar = new System.Windows.Forms.Button();
            this.modificarClase_textBoxHorario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modificarClase_comboBoxDia
            // 
            this.modificarClase_comboBoxDia.FormattingEnabled = true;
            this.modificarClase_comboBoxDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.modificarClase_comboBoxDia.Location = new System.Drawing.Point(121, 49);
            this.modificarClase_comboBoxDia.Name = "modificarClase_comboBoxDia";
            this.modificarClase_comboBoxDia.Size = new System.Drawing.Size(185, 23);
            this.modificarClase_comboBoxDia.TabIndex = 24;
            // 
            // modificarClase_comboBoxProfesor
            // 
            this.modificarClase_comboBoxProfesor.FormattingEnabled = true;
            this.modificarClase_comboBoxProfesor.Location = new System.Drawing.Point(121, 187);
            this.modificarClase_comboBoxProfesor.Name = "modificarClase_comboBoxProfesor";
            this.modificarClase_comboBoxProfesor.Size = new System.Drawing.Size(185, 23);
            this.modificarClase_comboBoxProfesor.TabIndex = 23;
            // 
            // modificarClase_buttonCerrar
            // 
            this.modificarClase_buttonCerrar.Location = new System.Drawing.Point(28, 272);
            this.modificarClase_buttonCerrar.Name = "modificarClase_buttonCerrar";
            this.modificarClase_buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.modificarClase_buttonCerrar.TabIndex = 22;
            this.modificarClase_buttonCerrar.Text = "Cerrar";
            this.modificarClase_buttonCerrar.UseVisualStyleBackColor = true;
            this.modificarClase_buttonCerrar.Click += new System.EventHandler(this.modificarClase_buttonCerrar_Click);
            // 
            // modificarClase_buttonGuardar
            // 
            this.modificarClase_buttonGuardar.Location = new System.Drawing.Point(213, 272);
            this.modificarClase_buttonGuardar.Name = "modificarClase_buttonGuardar";
            this.modificarClase_buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.modificarClase_buttonGuardar.TabIndex = 21;
            this.modificarClase_buttonGuardar.Text = "Modificar";
            this.modificarClase_buttonGuardar.UseVisualStyleBackColor = true;
            this.modificarClase_buttonGuardar.Click += new System.EventHandler(this.modificarClase_buttonGuardar_Click);
            // 
            // modificarClase_textBoxHorario
            // 
            this.modificarClase_textBoxHorario.Location = new System.Drawing.Point(121, 117);
            this.modificarClase_textBoxHorario.Name = "modificarClase_textBoxHorario";
            this.modificarClase_textBoxHorario.Size = new System.Drawing.Size(185, 23);
            this.modificarClase_textBoxHorario.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(13, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Profesor: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Horarios: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Día: ";
            // 
            // ModificarClase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 339);
            this.Controls.Add(this.modificarClase_comboBoxDia);
            this.Controls.Add(this.modificarClase_comboBoxProfesor);
            this.Controls.Add(this.modificarClase_buttonCerrar);
            this.Controls.Add(this.modificarClase_buttonGuardar);
            this.Controls.Add(this.modificarClase_textBoxHorario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModificarClase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Clase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox modificarClase_comboBoxDia;
        private System.Windows.Forms.ComboBox modificarClase_comboBoxProfesor;
        private System.Windows.Forms.Button modificarClase_buttonCerrar;
        private System.Windows.Forms.Button modificarClase_buttonGuardar;
        private System.Windows.Forms.TextBox modificarClase_textBoxHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}