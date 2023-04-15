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
    public partial class ModificarActivDepor : Form
    {
        private Inmobiliaria adModificada;
        public ModificarActivDepor(Inmobiliaria ad)
        {
            InitializeComponent();
            adModificada = ad;
            if (ad != null)
            {
                modifActividad_boxNombre.Text = ad.Nombre;
                modifActividad_boxDescrip.Text = ad.Descripcion;
                modifActividad_boxCantPersonas.Text = ad.MaxPersonas.ToString();
                modifActividad_boxCosto.Text = ad.Costo.ToString();
            }
        }

        public Inmobiliaria darActividad
        {
            get { return adModificada; }
        }

        private void modifActiv_botonGrabar_Click(object sender, EventArgs e)
        {
            string nom = modifActividad_boxNombre.Text;
            string descrip = modifActividad_boxDescrip.Text;
            double val = double.Parse(modifActividad_boxCosto.Text);
            int cantPer = int.Parse(modifActividad_boxCantPersonas.Text);
            if(adModificada != null)
            {
                adModificada.ModificarActividadDeportiva(nom, descrip, val, cantPer);
            }
            this.Close();
        }

        private void modifActiv_botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
