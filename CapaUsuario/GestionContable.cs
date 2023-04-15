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
    public partial class GestionContable : Form
    {
        private Empleado f;
        private Sucursal adm;
        private List<Empleado> lf;
        private List<Vivienda> listaSocios;
        private Vivienda s;
        public GestionContable(List<Empleado> listaFacturas, Sucursal a, List<Vivienda> listaSocios)
        {
            InitializeComponent();
            f = null;
            adm = a;
            lf = listaFacturas;
            listBox1_Socios.DataSource = null;
            listBox1_Socios.DataSource = listaSocios;
            listBox2_ListaFacturas.DataSource = null;
            listBox2_ListaFacturas.DataSource = listaFacturas;
        }

        private void gestionContable_botonPagar_Click(object sender, EventArgs e)
        {
            try
            {
                Vivienda soc = (Vivienda)listBox1_Socios.SelectedItem;
                double monto = double.Parse(gestionContable_textBoxTotal.Text);
                DateTime fechaPago = gestionContable_datePickerFechaPago.Value;
                if (listBox1_Socios.SelectedItem == null)
                    throw new NoSeleccion();
                if (adm.yaPago(soc) == true)
                    MessageBox.Show("Este Socio ya pago.");
                else
                {
                    f = new Empleado(adm.getListaFacturas().Count + 1, monto, fechaPago, soc);
                    adm.agregarFactura(f);
                    listBox1_Socios.DataSource = null;
                    listBox1_Socios.DataSource = adm.getListaSocios();
                    listBox2_ListaFacturas.DataSource = null;
                    listBox2_ListaFacturas.DataSource = adm.getListaFacturas();
                }
                
            }
            catch (NoSeleccion ex)
            {
                MessageBox.Show(ex.Message);
                listBox1_Socios.Focus();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CAMBIO DE ESTADO DE LISTBOX DE SOCIOS 
            Vivienda s = (Vivienda)listBox1_Socios.SelectedItem;
            if (s != null)
            {
                gestionContable_textBoxCuota.Text = s.darCuota().ToString();
                gestionContable_textBoxTotal.Text = s.darMontoActividades().ToString();
            }
        }

        private void gestionContable_botonRefrescar_Click(object sender, EventArgs e)
        {
            listBox1_Socios.DataSource = null;
            listBox1_Socios.DataSource = adm.getListaSocios();
        }

    }
}
