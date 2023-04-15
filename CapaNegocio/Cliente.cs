using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    [Serializable]
    public class Cliente : Persona
    {
        public string nroCliente;

        public Cliente(int dni, string nombre, string apellido, DateTime fechaNac, string sexo) : base(dni, nombre, apellido, fechaNac, sexo)
        {
        }

    }
}
