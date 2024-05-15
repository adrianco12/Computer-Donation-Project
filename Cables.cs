using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
        internal class Cables : Part
        {
        // Private fields
        private string type = "";
        private int length = 0;
        private string connectorType = "";


        // Properties with data validation
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string ConnectorType
        {
            get { return connectorType; }
            set { connectorType = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        // Constructor
        public Cables(string t, string ct, int l, string v, float p, string ma, string mo, string c) : base(v, p, ma, mo, c)
        {
            Type = t;
            ConnectorType = ct;
            Length = l;
        }

        // Overrides base class display method
        public override string getData()
        {
            return "Cable," + base.getData() + ",Type of Cable: " + Type + "    Connector Type: " + ConnectorType + "   Length: " + Length + " m";
        }
    }
}


