using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
using Excepciones;

namespace CapaUsuario
{
    public partial class AltaProfesor : Form
    {
        private Cliente p;
        private List<Cliente> lp;
        public AltaProfesor(List<Cliente> listaProfesores)
        {
            InitializeComponent();
            lp = listaProfesores;
            altaProfesor_boxNroProfesor.Text = (lp.Count + 1).ToString();
        }

        private void altaProfesor_botonGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = lp.Count + 1;
                int dni = int.Parse(altaProfesor_boxDNI.Text);
                string nombre = altaProfesor_boxNombre.Text;
                string apellido = altaProfesor_boxApellido.Text;
                DateTime fechaNac = altaProfesor_boxFechaNac.Value;
                string sexo = altaProfesor_boxSexo.Text;
                string alias = altaProfesor_textBoxAlias.Text;
                if (apellido.Length == 0 || nombre.Length == 0 || sexo.Length == 0 || alias.Length == 0)
                    throw new BlancoException();

                if (fechaNac.Date == DateTime.Today)
                    throw new FechaNacHoy();

                p = new Cliente(id, dni, nombre, apellido, fechaNac, sexo, alias, "A");
                this.Close();
                
            }
            catch (BlancoException ex)
            {
                MessageBox.Show(ex.Message);
                altaProfesor_boxApellido.Focus();
            }
            catch (FechaNacHoy ex)
            {
                MessageBox.Show(ex.Message);
                altaProfesor_boxFechaNac.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void altaProfesor_botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Cliente darProfesor()
        {
            return p;
        }
    }
}
