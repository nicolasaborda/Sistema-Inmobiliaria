using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Departamento : Vivienda
    {
        public string nroDepto;
        public int piso;

        public Departamento(string direccion, float metrosCubiertos, int piso, string nroDepto) : base(direccion, metrosCubiertos)
        {
            this.piso = piso;
            this.nroDepto = nroDepto;
        }


    }


}
