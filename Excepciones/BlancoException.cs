using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class BlancoException : Exception
    {
        public BlancoException()
                : base("Campo en blanco")
        {
        }
    }
}
