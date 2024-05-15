using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalProject
{
    internal class Part
    {
        private string vendor = "";
        private float price;
        private string make = "";
        private string model = "";
        private string comments = "";

        public string Vendor
        {
            get { return vendor; }
            set { vendor = value; }
        }

        public float Price
        { 
            get { return price; } 
            set {  price = value; } 
        }

        public string Make
        { 
            get { return make; } 
            set {  make = value; } 
        }

        public string Model
        { 
           get { return model; } 
           set { model = value; }
        }
        
        public string Comment
        { 
          get { return comments; }
            set {  
                if (value == ",")
                {
                    throw new InvalidParts("Please include a comment (can be 'no comment')");
                }   
                comments = value; 
            }
        }

        //public constructor
        public Part()
        {
            vendor = "";
            make = "";
            model = "";
            comments = "No comments.";
            price = 0;
            make = "";
        } 

        // overloaded constructor
        public Part(string v, float p, string m, string mk, string c)
        {
            Vendor = v;
            Model = m;
            Comment = c;
            Price = p;
            Make = mk;
        }

        //virtual display method
        public virtual string getData()
        {
            return Vendor + "," + Price.ToString() + "," + Model + "," + Make + "," + Comment;
        }

    }
}

