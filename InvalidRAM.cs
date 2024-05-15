using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class InvalidRAM : Exception
    {
        public InvalidRAM(String errRAM) : base(errRAM)
        { }
    }
}
