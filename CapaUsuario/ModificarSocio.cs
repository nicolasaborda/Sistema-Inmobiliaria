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
    public partial class ModificarSocio : Form
    {
        private Vivienda socioModificado;
        public ModificarSocio(Vivienda s)
        {
            InitializeComponent();
            socioModificado = s;

            if (s != null)
            {
                modificaSocio_boxNombre.Text = s.Nombre;
                modificaSocio_boxApellido.Text = s.Apellido;
                modificaSocio_boxDNI.Text = s.Dni.ToString();
                modificaSocio_boxFechaNac.Value = s.FechaNac;
                modificaSocio_boxSexo.Text = s.Sexo;
            }

        }
        public Vivienda darSocio()
        {
            return socioModificado;
        }

        private void modificaSocio_botonGrabar_Click(object sender, EventArgs e)
        {

            string nombre = modificaSocio_boxNombre.Text;
            string apellido = modificaSocio_boxApellido.Text;
            int dni = int.Parse(modificaSocio_boxDNI.Text);
            DateTime fechaNac = modificaSocio_boxFechaNac.Value;
            string sexo = modificaSocio_boxSexo.Text;
            
            if(socioModificado != null)
            {
                socioModificado.ModificarSocio(dni, nombre, apellido, fechaNac, sexo);
            }
            
            this.Close();

        }

        private void modificaSocio_botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
