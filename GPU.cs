using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class GPU : Part
    {
        private int memory;

        //public constructors
        public GPU() : base()
        {
            memory = 0;
        }

        //overloaded constructor
        public GPU(int mem, string v, float p, string m, string mk, string c) : base(v, p, m, mk, c)
        {
            int memory = mem;
        }

        //public properties
        public int Memory
        {
            get { return memory; }
            set { memory = value; }
        }
        public override string getData()
        {
            return "GPU," + base.getData() + ",Memory: " + Memory;
        }
    }
}


