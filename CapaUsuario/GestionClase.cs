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
    public partial class GestionClase : Form
    {
        private Persona c;
        private Sucursal adm;
        private Inmobiliaria ad;
        public GestionClase(Sucursal cb)
        {
            InitializeComponent();
            c = null;
            adm = cb;
            listBox1_Clases.DataSource = null;
            listBox1_Clases.DataSource = adm.getListaClases();

        }

        private void gestionClase_botonInscribirSocio_Click(object sender, EventArgs e)
        {
            c = listBox1_Clases.SelectedItem as Persona;
            InscribirSocio asignarSocio = new InscribirSocio(c, adm.getListaSocios());
            asignarSocio.ShowDialog();

            listBox1_Clases.DataSource = null;
            listBox1_Clases.DataSource = adm.getListaClases();
        }

        private void gestClase_botonModif_Click(object sender, EventArgs e)
        {
            c = listBox1_Clases.SelectedItem as Persona;
            ModificarClase modificarClase = new ModificarClase(c, adm.getListaProfesores());
            modificarClase.ShowDialog();

            c = modificarClase.darClase();

            if (c != null)
            {
                adm.ModificarClase(c);
                listBox1_Clases.DataSource = null;
                listBox1_Clases.DataSource = adm.getListaClases();
            }

            listBox1_Clases.DataSource = null;
            listBox1_Clases.DataSource = adm.getListaClases();
        }

        private void gestClase_botonEliminar_Click(object sender, EventArgs e)
        {
            c = listBox1_Clases.SelectedItem as Persona;
            adm.BorrarClase(c);

            listBox1_Clases.DataSource = null;
            listBox1_Clases.DataSource = adm.getListaClases();
        }

        private void gestClase_botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionClase_botonAgregarClaseNueva_Click(object sender, EventArgs e)
        {
            AltaClase claseNueva = new AltaClase(adm.getListaActividadesDeportivas(), adm.getListaProfesores(), adm.getListaClases());
            //claseNueva.ShowInTaskbar = false;
            claseNueva.ShowDialog();
            c = claseNueva.darClase();

            if (c != null)
            {
                adm.agregarClase(c);
                listBox1_Clases.DataSource = null;
                listBox1_Clases.DataSource = adm.getListaClases();
            }
        }
    }
}
