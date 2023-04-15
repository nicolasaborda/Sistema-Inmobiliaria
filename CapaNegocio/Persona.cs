using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CapaNegocio
{
    // [Serializable]
    public abstract class Persona
    {
        private int dni;
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private string sexo;

        public Persona(int dni, string nombre, string apellido, DateTime fechaNac, string sexo)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.sexo = sexo;
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

    }   
}
