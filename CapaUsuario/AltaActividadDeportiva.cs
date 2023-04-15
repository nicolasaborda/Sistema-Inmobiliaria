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
    public partial class AltaActividadDeportiva : Form
    {
        private Inmobiliaria ad;
        List<Inmobiliaria> listaActividades;
        public AltaActividadDeportiva(List<Inmobiliaria> listaAD)
        {
            InitializeComponent();
            listaActividades = listaAD;
        }

        public Inmobiliaria darActividad
        {
            get { return ad; }
        }

        private void altaSocio_botonGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = listaActividades.Count + 1;
                string nom = altaActividad_boxNombre.Text;
                string descrip = altaActividad_boxDescrip.Text;
                double val = double.Parse(altaActividad_boxCosto.Text);
                int cantPer = int.Parse(altaActividad_boxCantPersonas.Text);
                if (nom.Length == 0 || descrip.Length == 0)
                    throw new BlancoException();
                else
                {
                    ad = new Inmobiliaria(id, nom, descrip, val, cantPer);
                    this.Close();
                }
            }
            catch(BlancoException ex)
            {
                MessageBox.Show(ex.Message);
                altaActividad_boxNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void altaSocio_botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
