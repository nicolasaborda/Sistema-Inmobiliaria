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
    public partial class GestionSocio : Form
    {
        private Vivienda s;
        private Sucursal adm;

        public GestionSocio(List<Vivienda> listaSocios, Sucursal a)
        {
            InitializeComponent();
            s = null;
            adm = a;

            listBox1_Socios.DataSource = null;
            listBox1_Socios.DataSource = listaSocios;

        }

        private void gestSocio_botonCrear_Click(object sender, EventArgs e)
        {
            AltaSocio socioNuevo = new AltaSocio(adm.getListaSocios());
            socioNuevo.ShowDialog();

            s = socioNuevo.darSocio();

            if (s != null)
            {
                adm.agregarSocio(s);
                listBox1_Socios.DataSource = null;
                listBox1_Socios.DataSource = adm.getListaSocios();
            }
        }

        private void gestSocio_botonModif_Click(object sender, EventArgs e)
        {
            Vivienda s = (Vivienda)listBox1_Socios.SelectedItem;
            ModificarSocio socioModif = new ModificarSocio(s);
            socioModif.ShowDialog();

            s = socioModif.darSocio();

            if (s != null)
            {
                adm.ModificarSocio(s);
                listBox1_Socios.DataSource = null;
                listBox1_Socios.DataSource = adm.getListaSocios();
            }

        }

        private void gestSocio_botonEliminar_Click(object sender, EventArgs e)
        {
            s = listBox1_Socios.SelectedItem as Vivienda;
            adm.BorrarSocio(s);

            listBox1_Socios.DataSource = null;
            listBox1_Socios.DataSource = adm.getListaSocios();
        }

        private void gestSocio_botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestSocio_botonActivo_Click(object sender, EventArgs e)
        {
            s = listBox1_Socios.SelectedItem as Vivienda;
            if (s.Status == "A")
                MessageBox.Show("El Socio ya esta Activo.");
            else
                s.Status = "A";
            listBox1_Socios.DataSource = null;
            listBox1_Socios.DataSource = adm.getListaSocios();
        }

        private void gestSocio_botonInactivo_Click(object sender, EventArgs e)
        {
            s = listBox1_Socios.SelectedItem as Vivienda;
            if (s.Status == "I")
                MessageBox.Show("El Socio ya esta Inactivo.");
            else
                s.Status = "I";
            listBox1_Socios.DataSource = null;
            listBox1_Socios.DataSource = adm.getListaSocios();
        }
    }
}
