using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class CPU : Part
    {
        //private data feilds
        private String socketType;
        private int coreCount;
        float clockSpeed;

        //public constructors
        public CPU() : base()
        {
            socketType = "";
            coreCount = 0;
            clockSpeed = 0;
        }

        //overloaded constuctor
        public CPU(string st, int cc, float cs, string v, float p, string m, string mk, string c) : base(v, p, m, mk, c)
        {
            socketType = st;
            coreCount = cc;
            clockSpeed = cs;
        }

        //public properties
        public string SocketType
        {
            get { return socketType; }
            set { socketType = value; }
        }
        public int CoreCount
        {
            get { return coreCount; }
            set { coreCount = value; }
        }
        public float ClockSpeed
        {
            get { return clockSpeed; }
            set { clockSpeed = value; }
        }
        //overide method
        public override string getData()
        {
            return "CPU," + base.getData() + ",Socket Type: " + SocketType + "   Core Count: " + CoreCount.ToString() + "    Clock Speed: " + ClockSpeed.ToString();
        }
    }

}

