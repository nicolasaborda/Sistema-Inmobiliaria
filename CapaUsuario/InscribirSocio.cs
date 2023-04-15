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
    public partial class InscribirSocio : Form
    {
        private List<Vivienda> listaSocios;
        private Vivienda s;
        private Persona cl;
        public InscribirSocio(Persona c, List<Vivienda> ls)
        {
            InitializeComponent();
            listaSocios = ls;
            cl = c;
            listBox1_Socios.DataSource = null;
            listBox1_Socios.DataSource = ls;
            listBox2_Inscriptos.DataSource = null;
            listBox2_Inscriptos.DataSource = c.ListaSocios;
            inscribirSocio_textBoxAD.Text = c.Actividad.Nombre;
            inscribirSocio_textBoxClase.Text = c.Dia +" "+ c.Horario;
        }

        private void inscribirSocio_botonInscribir_Click(object sender, EventArgs e)
        {
            try
            {
                s = listBox1_Socios.SelectedItem as Vivienda;
                if (cl.claseLlena()) //si no hay cupo
                    throw new ClaseLlena();

                cl.InscribirSocio(s);
                listBox1_Socios.DataSource = null;
                listBox1_Socios.DataSource = listaSocios;
                listBox2_Inscriptos.DataSource = null;
                listBox2_Inscriptos.DataSource = cl.ListaSocios;
            }
            catch (ClaseLlena ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inscribirSocio_botonDesinscribir_Click(object sender, EventArgs e)
        {
            s = listBox2_Inscriptos.SelectedItem as Vivienda;
            cl.DesInscribirSocio(s);
            listBox1_Socios.DataSource = null;
            listBox1_Socios.DataSource = listaSocios;
            listBox2_Inscriptos.DataSource = null;
            listBox2_Inscriptos.DataSource = cl.ListaSocios;
        }

        private void inscribirSocio_botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
