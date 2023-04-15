
namespace CapaUsuario
{
    partial class Principal
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Socios");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Profesores");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Actividades");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Clases");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Pagos");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Club Deportivo", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.inicio_botonSocio = new System.Windows.Forms.Button();
            this.inicio_botonProfesor = new System.Windows.Forms.Button();
            this.inicio_botonActividadDepo = new System.Windows.Forms.Button();
            this.inicio_botonPago = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inicio_botonClases = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // inicio_botonSocio
            // 
            this.inicio_botonSocio.Location = new System.Drawing.Point(28, 295);
            this.inicio_botonSocio.Name = "inicio_botonSocio";
            this.inicio_botonSocio.Size = new System.Drawing.Size(145, 23);
            this.inicio_botonSocio.TabIndex = 0;
            this.inicio_botonSocio.Text = "Gestion Socio";
            this.inicio_botonSocio.UseVisualStyleBackColor = true;
            this.inicio_botonSocio.Click += new System.EventHandler(this.inicio_botonSocio_Click);
            // 
            // inicio_botonProfesor
            // 
            this.inicio_botonProfesor.Location = new System.Drawing.Point(29, 325);
            this.inicio_botonProfesor.Name = "inicio_botonProfesor";
            this.inicio_botonProfesor.Size = new System.Drawing.Size(144, 23);
            this.inicio_botonProfesor.TabIndex = 1;
            this.inicio_botonProfesor.Text = "Gestion Profesor";
            this.inicio_botonProfesor.UseVisualStyleBackColor = true;
            this.inicio_botonProfesor.Click += new System.EventHandler(this.inicio_botonProfesor_Click);
            // 
            // inicio_botonActividadDepo
            // 
            this.inicio_botonActividadDepo.Location = new System.Drawing.Point(29, 355);
            this.inicio_botonActividadDepo.Name = "inicio_botonActividadDepo";
            this.inicio_botonActividadDepo.Size = new System.Drawing.Size(144, 23);
            this.inicio_botonActividadDepo.TabIndex = 2;
            this.inicio_botonActividadDepo.Text = "Gestion Actividad Deportiva";
            this.inicio_botonActividadDepo.UseVisualStyleBackColor = true;
            this.inicio_botonActividadDepo.Click += new System.EventHandler(this.inicio_botonActividadDepo_Click);
            // 
            // inicio_botonPago
            // 
            this.inicio_botonPago.Location = new System.Drawing.Point(28, 417);
            this.inicio_botonPago.Name = "inicio_botonPago";
            this.inicio_botonPago.Size = new System.Drawing.Size(145, 23);
            this.inicio_botonPago.TabIndex = 3;
            this.inicio_botonPago.Text = "Gestion Pago";
            this.inicio_botonPago.UseVisualStyleBackColor = true;
            this.inicio_botonPago.Click += new System.EventHandler(this.inicio_botonPago_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu Inicial";
            // 
            // inicio_botonClases
            // 
            this.inicio_botonClases.Location = new System.Drawing.Point(29, 385);
            this.inicio_botonClases.Name = "inicio_botonClases";
            this.inicio_botonClases.Size = new System.Drawing.Size(144, 23);
            this.inicio_botonClases.TabIndex = 5;
            this.inicio_botonClases.Text = "Gestion Clases";
            this.inicio_botonClases.UseVisualStyleBackColor = true;
            this.inicio_botonClases.Click += new System.EventHandler(this.inicio_botonClases_Click);
            // 
            // treeView2
            // 
            this.treeView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView2.Location = new System.Drawing.Point(12, 44);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Socios";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Profesores";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Actividades";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Clases";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Pagos";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Club Deportivo";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView2.Size = new System.Drawing.Size(183, 214);
            this.treeView2.TabIndex = 7;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(225, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(580, 496);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 520);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.inicio_botonClases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inicio_botonPago);
            this.Controls.Add(this.inicio_botonActividadDepo);
            this.Controls.Add(this.inicio_botonProfesor);
            this.Controls.Add(this.inicio_botonSocio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Club Deportivo Morón";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button inicio_botonSocio;
        private System.Windows.Forms.Button inicio_botonProfesor;
        private System.Windows.Forms.Button inicio_botonActividadDepo;
        private System.Windows.Forms.Button inicio_botonPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button inicio_botonClases;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

