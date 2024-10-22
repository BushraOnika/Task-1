using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Town
    {
        public string city, name, postalcode;
        public Town() { }
        public Town(string name) { 
            this.name = name;
        
        }
        public Town(string city, string name, string postalcode) { 
            this.city = city;
            this.name = name;
            this.postalcode = postalcode;
        
        }
        public override string ToString()
        {
            return $"Town: {name}, City: {city}, Postal Code: {postalcode}";
        }

    }
}
