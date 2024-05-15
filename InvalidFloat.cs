using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class InvalidFloat : Exception
    {
        public InvalidFloat(String errFloat) : base(errFloat)
        { }
    }
}
