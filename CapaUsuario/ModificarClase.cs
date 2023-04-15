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
    public partial class ModificarClase : Form
    {
        private Persona claseModificada;
        public ModificarClase(Persona c, List<Cliente> listaProfesores)
        {
            InitializeComponent();
            claseModificada = c;

            if (c != null)
            {
                modificarClase_comboBoxDia.Text = c.Dia;
                modificarClase_textBoxHorario.Text = c.Horario;
                modificarClase_comboBoxProfesor.Text = c.Profesor.darNombre();
                modificarClase_comboBoxProfesor.DataSource = listaProfesores;
            }
        }

        public Persona darClase()
        {
            return claseModificada;
        }

        private void modificarClase_buttonGuardar_Click(object sender, EventArgs e)
        {
            string dia = modificarClase_comboBoxDia.Text;
            string horario = modificarClase_textBoxHorario.Text;
            Cliente profe = (Cliente)modificarClase_comboBoxProfesor.SelectedItem;

            if (claseModificada != null)
            {
                claseModificada.ModificarClase(dia, horario, profe);
            }

            this.Close();
        }

        private void modificarClase_buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
