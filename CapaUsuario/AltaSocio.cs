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
    public partial class AltaSocio : Form
    {
        private Vivienda s;
        private List<Vivienda> ls;
        public AltaSocio(List<Vivienda> listaSocios)
        {
            InitializeComponent();
            ls = listaSocios;
            altaSocio_boxNumSocio.Text = (ls.Count + 1).ToString();
            altaSocio_boxCuota.Hide();
            label9.Hide();
        }

        private void altaSocio_botonGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = ls.Count + 1;
                int dni = int.Parse(altaSocio_boxDNI.Text);
                string nombre = altaSocio_boxNombre.Text;
                string apellido = altaSocio_boxApellido.Text;
                DateTime fechaNac = altaSocio_boxFechaNac.Value;
                string sexo = altaSocio_boxSexo.Text;
                if (nombre.Length == 0 || apellido.Length == 0 || sexo.Length == 0)
                    throw new BlancoException();

                if (fechaNac.Date == DateTime.Today)
                    throw new FechaNacHoy();

                if (altaSocio_comboBox1.SelectedItem == null)
                    throw new NoSeleccion();

                if (altaSocio_comboBox1.Text.Contains("De Actividad"))
                {
                    s = new Transaccion(id, dni, nombre, apellido, fechaNac, sexo, "A");
                    this.Close();
                }
                else
                {
                     float cuotaS = float.Parse(altaSocio_boxCuota.Text);
                     s = new Reserva(id, dni, nombre, apellido, fechaNac, sexo, "A", cuotaS);
                     this.Close();
                }
                this.Close();
            }
            catch (FechaNacHoy ex)
            {
                MessageBox.Show(ex.Message);
                altaSocio_boxFechaNac.Focus();
            }
            catch (BlancoException ex)
            {
                MessageBox.Show(ex.Message);
                altaSocio_boxNombre.Focus();
            }
            catch(NoSeleccion ex)
            {
                MessageBox.Show(ex.Message);
                altaSocio_comboBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void tipoSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (altaSocio_comboBox1.Text != "De Club")
            {
                label9.Visible = false;
                altaSocio_boxCuota.Visible = false;
            }
            else
            {
                label9.Visible = true;
                altaSocio_boxCuota.Visible = true;
            }


        }

        private void altaSocio_botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Vivienda darSocio()
        {
            return s;
        }

    }
}
