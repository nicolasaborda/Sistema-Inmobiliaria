using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaUsuario
{
    public partial class ModificarProfesor : Form
    {
        private Cliente profModificado;
        public ModificarProfesor(Cliente p)
        {
            InitializeComponent();
            profModificado = p;
            if (p != null)
            {
                modifProfesor_boxNombre.Text = p.Nombre;
                modifProfesor_boxApellido.Text = p.Apellido;
                modifProfesor_boxDNI.Text = p.Dni.ToString();
                modifProfesor_boxSexo.Text = p.Sexo.ToString();
                modifProfesor_boxFechaNac.Value = p.FechaNac;
                modifProfesor_textBoxAlias.Text = p.Alias.ToString(); ;
            }
        }

        public Cliente darProfesor()
        {
            return profModificado;
        }

        private void modifProfesor_botonGrabar_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(modifProfesor_boxDNI.Text);
            string nombre = modifProfesor_boxNombre.Text;
            string apellido = modifProfesor_boxApellido.Text;
            DateTime fechaNac = modifProfesor_boxFechaNac.Value;
            string sexo = modifProfesor_boxSexo.Text;
            string alias = modifProfesor_textBoxAlias.Text;

            if (profModificado != null)
            {
                profModificado.ModificarProfesor(dni, nombre, apellido, fechaNac, sexo, alias);
            }
            this.Close();

        }

        private void modifProfesor_botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
