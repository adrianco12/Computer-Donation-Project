using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class RAM : Part
    {
        // private fields
        private int speed;
        private int capacity;

        // public properties
        public int Speed
        { 
            get { return speed; } 
            set 
            {
                if (value < 0)
                {
                    throw new InvalidRAM("Speed value must be a positive integer");
                }
                speed = value;
            } 
        }

        public int Capacity 
        { 
            get { return capacity; }
            set 
            {
                if (value < 0)
                {
                    throw new InvalidRAM("Capacity value must be a positive integer");
                }
                capacity = value; 
            } 
        }

        // constructor to instantiate class, inherits from base class
        public RAM (int s, int c, string v, float p, string ma, string mo, string co): base(v, p, ma, mo, co)
        {
            Speed = s;
            Capacity = c;
        }

        // method that overrides display method
        public override string getData()
        {
            return "RAM," + base.getData() + ",Speed: " + speed.ToString() + "MHz   Capacity: " + capacity.ToString() + "GB";
        }
    }
}
