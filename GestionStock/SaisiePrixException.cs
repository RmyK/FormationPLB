using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    class SaisiePrixException : Exception
    {
        public SaisiePrixException(string message, Exception ex) : base(message, ex)
        {

        }
    }
}
