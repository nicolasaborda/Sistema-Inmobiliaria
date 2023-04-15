using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CapaNegocio
{
    //[Serializable]
    public class Empleado : Persona
    {
        public string nroEmpleado;

        public Empleado(int dni, string nombre, string apellido, DateTime fechaNac, string sexo) : base(dni, nombre, apellido, fechaNac, sexo)
        {
        }
    }
}
