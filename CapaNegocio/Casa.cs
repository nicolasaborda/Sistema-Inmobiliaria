using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Casa : Vivienda
    {
        public float metrosTerreno;

        public Casa(string direccion, float metrosCubiertos) : base(direccion, metrosCubiertos)
        {
        }
    }
}
