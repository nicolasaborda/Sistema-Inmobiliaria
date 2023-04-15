using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class FechaNacHoy : Exception
    {
        public FechaNacHoy()
                : base("La Fecha de Nacimiento no puede ser la fecha de hoy.")
        {
        }
    }
}
