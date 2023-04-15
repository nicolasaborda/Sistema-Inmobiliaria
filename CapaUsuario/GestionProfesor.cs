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
    public partial class GestionProfesor : Form
    {
        private Cliente p;
        private Sucursal adm;
        public GestionProfesor(List<Cliente> listaProfesores, Sucursal a)
        {
            InitializeComponent();
            p = null;
            adm = a;

            listBox1_Profesor.DataSource = null;
            listBox1_Profesor.DataSource = listaProfesores;
        }
        private void gestProfesor_botonCrear_Click(object sender, EventArgs e)
        {
            AltaProfesor profesorNuevo = new AltaProfesor(adm.getListaProfesores());
            profesorNuevo.ShowDialog();

            p = profesorNuevo.darProfesor();

            if (p != null)
            {
                adm.agregarProfesor(p);
                listBox1_Profesor.DataSource = null;
                listBox1_Profesor.DataSource = adm.getListaProfesores();
            }
        }

        private void gestProfesor_botonModif_Click(object sender, EventArgs e)
        {
            Cliente p = (Cliente)listBox1_Profesor.SelectedItem;
            ModificarProfesor profesorModif = new ModificarProfesor(p);
            profesorModif.ShowDialog();

            p = profesorModif.darProfesor();

            if (p != null)
            {
                adm.ModificarProfesor(p);
                listBox1_Profesor.DataSource = null;
                listBox1_Profesor.DataSource = adm.getListaProfesores();
            }
        }

        private void gestProfesor_botonEliminar_Click(object sender, EventArgs e)
        {
            p = listBox1_Profesor.SelectedItem as Cliente;
            adm.BorrarProfesor(p);

            listBox1_Profesor.DataSource = null;
            listBox1_Profesor.DataSource = adm.getListaProfesores();
        }

        private void gestProfesor_botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestProfesor_botonActivo_Click(object sender, EventArgs e)
        {
            p = listBox1_Profesor.SelectedItem as Cliente;
            if (p.Status == "A")
                MessageBox.Show("El Profesor ya esta Activo.");
            else
                p.Status = "A";
            listBox1_Profesor.DataSource = null;
            listBox1_Profesor.DataSource = adm.getListaProfesores();
        }

        private void gestProfesor_botonInactivo_Click(object sender, EventArgs e)
        {
            p = listBox1_Profesor.SelectedItem as Cliente;
            if (p.Status == "I")
                MessageBox.Show("El Profesor ya esta Inactivo.");
            else
                p.Status = "I";
            listBox1_Profesor.DataSource = null;
            listBox1_Profesor.DataSource = adm.getListaProfesores();
        }
    }
}
