using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject
    {
        internal class Other : Part
        {
            // Private fields
            private string type = "";

            // Properties
            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            // Constructor
            public Other(string t, string v, float p, string m, string mk, string c) : base(v, p, m, mk, c)
            {
                Type = t;
            }

            // Overrides base class display method
            public override string getData()
            {
                return "Other," + base.getData() + ",Type of Part: " + Type;
            }
        }
}

