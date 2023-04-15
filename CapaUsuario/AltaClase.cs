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
    public partial class AltaClase : Form
    {
        private Persona c;
        private List<Persona> lc { get; set; }
        public AltaClase(List<Inmobiliaria> listaActividades, List<Cliente> listaProfesores, List<Persona> listaClases)
        {
            InitializeComponent();
            lc = listaClases;
            altaClase_comboBoxProfesores.DataSource = listaProfesores;
            altaClase_comboBoxActDeportiva.DataSource = listaActividades;
        }

        public Persona darClase()
        {
            return c;
        }

        private void altaClase_botonGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                int idClase = lc.Count + 1;
                String dia = altaClase_comboBoxDia.Text;
                String horarios = altaClase_boxHorario.Text;
                Cliente profe = (Cliente)altaClase_comboBoxProfesores.SelectedItem;
                Inmobiliaria actividad = (Inmobiliaria)altaClase_comboBoxActDeportiva.SelectedItem;
                if (dia.Length == 0 || horarios.Length == 0)
                {
                    MessageBoxIcon.Warning.ToString("Complete todos los campos antes de Grabar.");
                }
                else
                {
                    c = new Persona(idClase, dia, horarios, profe, actividad);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error inserpetado: " + ex.ToString(), " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void altaClase_botonSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
