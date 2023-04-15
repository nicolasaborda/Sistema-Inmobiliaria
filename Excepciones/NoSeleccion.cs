using System;

namespace Excepciones
{
    public class NoSeleccion : Exception
    {
        public NoSeleccion()
                : base("No seleccionó nada en la lista")
        {
        }
    }
}
