using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Person 
    {
        private string name;
        private int age;
        private string relation;
        public string profession;
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
        public Person (string profession, string name, int age, string relation)
        {
            this.relation = relation;
            this.name = name;
            this.age = age;
            this.profession = profession;
           
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
            return $"Name: {name}, Age: {age}, Profession : {profession}";
        }
    }
}
