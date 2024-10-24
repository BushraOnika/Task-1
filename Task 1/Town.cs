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
        List<Person> p;
        public Town() { }
        public Town(string name) { 
            this.name = name;
            p = new List<Person>();

        }
        public Town(string city, string name, string postalcode) { 
            this.city = city;
            this.name = name;
            this.postalcode = postalcode;
            p = new List<Person>();


        }
        public void addPerson (Person p1)
        {
            p.Add(p1);
        }
        public override string ToString()
        {
            return $"Town: {name}, City: {city}, Postal Code: {postalcode} , Person : {p} ";
        }

    }
}
