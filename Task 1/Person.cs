using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Person : Town
    {
        private string name;
        private int age;
        private string relation;
        public Town town;
        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person(string name, int age, string relation)
        {
            this.relation = relation;
            this.name = name;
            this.age= age;
            
        }
        public Person (Town town, string name, int age, string relation)
        {
            this.relation = relation;
            this.name = name;
            this.age = age;
            this.town = town;
           
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
            { 
            get { return age; } 
            set { age = value; }
        }
       public string Relation
        {
            get { return relation; }
            set { relation = value; }
        }
        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, Town: {town.ToString()}";
        }
    }
}
