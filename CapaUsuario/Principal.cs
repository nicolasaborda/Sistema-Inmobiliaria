using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaUsuario
{
    public partial class Principal : Form
    {
        private Sucursal adm;
        public Principal()
        {
            InitializeComponent();
            Sucursal.PonerPathABaseAccess(Application.StartupPath);
            adm = new Sucursal();

        }

        private void inicio_botonSocio_Click(object sender, EventArgs e)
        {
            //ABM SOCIOS
            GestionSocio soc = new GestionSocio(adm.getListaSocios(), adm);
            soc.ShowDialog();
        }

        private void inicio_botonProfesor_Click(object sender, EventArgs e)
        {
            //ABM PROFESORES
            GestionProfesor prof = new GestionProfesor(adm.getListaProfesores(), adm);
            prof.ShowDialog();
        }

        private void inicio_botonActividadDepo_Click(object sender, EventArgs e)
        {
            //ABM ACTIVIDADES
            GestionActividadDeportiva activDepo = new GestionActividadDeportiva(adm.getListaActividadesDeportivas(), adm);
            activDepo.ShowDialog();
        }

        private void inicio_botonPago_Click(object sender, EventArgs e)
        {
            //ABM PAGOS
            if (adm.getListaSocios().Count == 0)
                MessageBox.Show("No hay socios registrados, no se pueden gestionar pagos.");
            else
            {
                GestionContable factura = new GestionContable(adm.getListaFacturas(), adm, adm.getListaSocios());
                factura.ShowDialog();
            }
        }

        private void inicio_botonClases_Click(object sender, EventArgs e)
        {
            //ABM CLASES
            GestionClase clase = new GestionClase(adm);
            clase.ShowDialog();
        }

     //   private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
  //      {
   //         string nod = treeView1.SelectedNode.Text;
    //        //ABM SOCIOS
    //        GestionSocio soc = new GestionSocio(adm.getListaSocios(), adm);
       //     soc.ShowDialog();


      //  }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string nod = treeView2.SelectedNode.Text;
            if (nod == "Socios")
            {
                // ABM SOCIOS
                GestionSocio soc = new GestionSocio(adm.getListaSocios(), adm);
                soc.ShowDialog();
            }else
                if(nod=="Profesores")
                {
                    //ABM PROFESORES
                    GestionProfesor prof = new GestionProfesor(adm.getListaProfesores(), adm);
                    prof.ShowDialog();
                }else
                    if(nod=="Actividades")
                    {   //ABM ACTIVIDADES
                        GestionActividadDeportiva activDepo = new GestionActividadDeportiva(adm.getListaActividadesDeportivas(), adm);
                        activDepo.ShowDialog();
                    }else
                        if(nod=="Pagos")
                        {   //ABM PAGOS
                            GestionContable factura = new GestionContable(adm.getListaFacturas(), adm, adm.getListaSocios());
                            factura.ShowDialog();
                        }else
                            {   
                                //ABM CLASES
                                GestionClase clase = new GestionClase(adm);
                                clase.ShowDialog();
                            }
        }
    }
}
