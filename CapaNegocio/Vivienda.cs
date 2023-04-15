using System;
using System.Collections;
using System.Collections.Generic;


namespace CapaNegocio
{
    // [Serializable]
    public abstract class Vivienda
    {
        public string direccion;
        public float metrosCubiertos;

        protected Vivienda(string direccion, float metrosCubiertos)
        {
            this.direccion = direccion;
            this.metrosCubiertos = metrosCubiertos;
        }

        
    }   
}
