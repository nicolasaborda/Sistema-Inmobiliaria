using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ClaseLlena : Exception
    {
        public ClaseLlena()
             : base("La clase no tiene más capacidad.")
        {
        }
    }
}
