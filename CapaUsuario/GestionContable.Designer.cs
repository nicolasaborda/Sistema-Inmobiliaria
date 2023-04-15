
namespace CapaUsuario
{
    partial class GestionContable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionContable));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_Socios = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gestionContable_datePickerFechaPago = new System.Windows.Forms.DateTimePicker();
            this.gestionContable_botonPagar = new System.Windows.Forms.Button();
            this.listBox2_ListaFacturas = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gestionContable_textBoxCuota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gestionContable_textBoxTotal = new System.Windows.Forms.TextBox();
            this.gestionContable_botonRefrescar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el Socio y luego complete los datos para el Pago";
            // 
            // listBox1_Socios
            // 
            this.listBox1_Socios.FormattingEnabled = true;
            this.listBox1_Socios.HorizontalScrollbar = true;
            this.listBox1_Socios.ItemHeight = 15;
            this.listBox1_Socios.Location = new System.Drawing.Point(16, 40);
            this.listBox1_Socios.Name = "listBox1_Socios";
            this.listBox1_Socios.ScrollAlwaysVisible = true;
            this.listBox1_Socios.Size = new System.Drawing.Size(328, 94);
            this.listBox1_Socios.TabIndex = 1;
            this.listBox1_Socios.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Pago";
            // 
            // gestionContable_datePickerFechaPago
            // 
            this.gestionContable_datePickerFechaPago.Location = new System.Drawing.Point(112, 144);
            this.gestionContable_datePickerFechaPago.Name = "gestionContable_datePickerFechaPago";
            this.gestionContable_datePickerFechaPago.Size = new System.Drawing.Size(232, 23);
            this.gestionContable_datePickerFechaPago.TabIndex = 3;
            // 
            // gestionContable_botonPagar
            // 
            this.gestionContable_botonPagar.Location = new System.Drawing.Point(16, 176);
            this.gestionContable_botonPagar.Name = "gestionContable_botonPagar";
            this.gestionContable_botonPagar.Size = new System.Drawing.Size(75, 23);
            this.gestionContable_botonPagar.TabIndex = 4;
            this.gestionContable_botonPagar.Text = "Pagar";
            this.gestionContable_botonPagar.UseVisualStyleBackColor = true;
            this.gestionContable_botonPagar.Click += new System.EventHandler(this.gestionContable_botonPagar_Click);
            // 
            // listBox2_ListaFacturas
            // 
            this.listBox2_ListaFacturas.FormattingEnabled = true;
            this.listBox2_ListaFacturas.HorizontalScrollbar = true;
            this.listBox2_ListaFacturas.ItemHeight = 15;
            this.listBox2_ListaFacturas.Location = new System.Drawing.Point(16, 282);
            this.listBox2_ListaFacturas.Name = "listBox2_ListaFacturas";
            this.listBox2_ListaFacturas.ScrollAlwaysVisible = true;
            this.listBox2_ListaFacturas.Size = new System.Drawing.Size(328, 94);
            this.listBox2_ListaFacturas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lista de Pagos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cuota $";
            // 
            // gestionContable_textBoxCuota
            // 
            this.gestionContable_textBoxCuota.Enabled = false;
            this.gestionContable_textBoxCuota.Location = new System.Drawing.Point(225, 183);
            this.gestionContable_textBoxCuota.Name = "gestionContable_textBoxCuota";
            this.gestionContable_textBoxCuota.Size = new System.Drawing.Size(100, 23);
            this.gestionContable_textBoxCuota.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total a Pagar";
            // 
            // gestionContable_textBoxTotal
            // 
            this.gestionContable_textBoxTotal.Enabled = false;
            this.gestionContable_textBoxTotal.Location = new System.Drawing.Point(224, 224);
            this.gestionContable_textBoxTotal.Name = "gestionContable_textBoxTotal";
            this.gestionContable_textBoxTotal.Size = new System.Drawing.Size(100, 23);
            this.gestionContable_textBoxTotal.TabIndex = 10;
            // 
            // gestionContable_botonRefrescar
            // 
            this.gestionContable_botonRefrescar.Location = new System.Drawing.Point(16, 215);
            this.gestionContable_botonRefrescar.Name = "gestionContable_botonRefrescar";
            this.gestionContable_botonRefrescar.Size = new System.Drawing.Size(75, 23);
            this.gestionContable_botonRefrescar.TabIndex = 11;
            this.gestionContable_botonRefrescar.Text = "Refrescar";
            this.gestionContable_botonRefrescar.UseVisualStyleBackColor = true;
            this.gestionContable_botonRefrescar.Click += new System.EventHandler(this.gestionContable_botonRefrescar_Click);
            // 
            // GestionContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 413);
            this.Controls.Add(this.gestionContable_botonRefrescar);
            this.Controls.Add(this.gestionContable_textBoxTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gestionContable_textBoxCuota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2_ListaFacturas);
            this.Controls.Add(this.gestionContable_botonPagar);
            this.Controls.Add(this.gestionContable_datePickerFechaPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1_Socios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionContable";
            this.Text = "GestionContable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1_Socios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker gestionContable_datePickerFechaPago;
        private System.Windows.Forms.Button gestionContable_botonPagar;
        private System.Windows.Forms.ListBox listBox2_ListaFacturas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gestionContable_textBoxCuota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gestionContable_textBoxTotal;
        private System.Windows.Forms.Button gestionContable_botonRefrescar;
    }
}