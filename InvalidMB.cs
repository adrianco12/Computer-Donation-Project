using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class InvalidMB: Exception
    {
        public InvalidMB(String errMB) : base(errMB)
        { }
    }
}
