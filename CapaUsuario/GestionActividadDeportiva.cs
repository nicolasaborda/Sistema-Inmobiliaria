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
    public partial class GestionActividadDeportiva : Form
    {
        private Inmobiliaria ad;
        private Sucursal adm;
        public GestionActividadDeportiva(List<Inmobiliaria> listaActividadDeportiva, Sucursal a)
        {
            InitializeComponent();
            ad = null;
            adm = a;
            listBox1_ActividadesDeportivas.DataSource = null;
            listBox1_ActividadesDeportivas.DataSource = listaActividadDeportiva;
        }

        private void gestActDep_botonCrear_Click(object sender, EventArgs e)
        {
            AltaActividadDeportiva actividadDeporNueva = new AltaActividadDeportiva(adm.getListaActividadesDeportivas());
            actividadDeporNueva.ShowDialog();

            ad = actividadDeporNueva.darActividad;

            if (ad != null)
            {
                adm.agregarActividadDeportiva(ad);
                listBox1_ActividadesDeportivas.DataSource = null;
                listBox1_ActividadesDeportivas.DataSource = adm.getListaActividadesDeportivas();
            }
        }

        private void gestActDep_botonModif_Click(object sender, EventArgs e)
        {
            Inmobiliaria ad = (Inmobiliaria)listBox1_ActividadesDeportivas.SelectedItem;
            ModificarActivDepor actividadDeporModif = new ModificarActivDepor(ad);
            actividadDeporModif.ShowDialog();
            //CONFIRMAR SI ESTA OK
            ad = actividadDeporModif.darActividad;

            if (ad !=null)
            {
                adm.ModificarActividad(ad);//CONFIRMAR SI ESTA OK
                listBox1_ActividadesDeportivas.DataSource = null;
                listBox1_ActividadesDeportivas.DataSource = adm.getListaActividadesDeportivas();
            }            
        }

        private void gestActDep_botonEliminar_Click(object sender, EventArgs e)
        {
            ad = listBox1_ActividadesDeportivas.SelectedItem as Inmobiliaria;
            adm.BorrarActividad(ad);

            listBox1_ActividadesDeportivas.DataSource = null;
            listBox1_ActividadesDeportivas.DataSource = adm.getListaActividadesDeportivas();
        }

        private void gestActDep_botonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
