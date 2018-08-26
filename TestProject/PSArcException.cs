using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSArcLib
{
    public class PSArcException : Exception
    {
        public PSArcException() : base()
        {

        }

        public PSArcException(string msg) : base(msg)
        {

        }

        public PSArcException(string msg, Exception innerException) : base(msg, innerException)
        {

        }
    }
}
