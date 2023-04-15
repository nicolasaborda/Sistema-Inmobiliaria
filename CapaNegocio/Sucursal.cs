using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CapaNegocio
{
    //[Serializable]
    public class Sucursal
    {
        public string localidad;
        public float valorMetroCubierto;
        public float valorMetroTerreno;

        public Sucursal(string localidad, float valorMetroCubierto, float valorMetroTerreno)
        {
            this.localidad = localidad;
            this.valorMetroCubierto = valorMetroCubierto;
            this.valorMetroTerreno = valorMetroTerreno;
        }
    }
}
