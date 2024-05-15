using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Motherboard : Part
    {
        private string formFactor = "";
        private string socketType = "";

        public string FormFactor
        { 
            get { return formFactor; } 
            set {  formFactor = value; } 
        }

        public string SocketType
        { get { return socketType; } set {  socketType = value; } }

        public Motherboard(string f, string s, string v, float p, string ma, string mo, string c): base(v, p, ma, mo, c)
        {
            FormFactor = f;
            SocketType = s;
        }

        public override string getData()
        {
            return "Motherboard," + base.getData() + ",Form Factor: " + FormFactor + "   Socket Type: " + SocketType;
        }
    }
}
