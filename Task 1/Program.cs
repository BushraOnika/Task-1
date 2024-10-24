using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Town t1= new Town("Dhaka");
            Town t2 = new Town("Bhoso","Chittagong", "B488D");
            Person p = new Person("Doctor","Bush",25,"Son");

            t2.addPerson(p);
            Console.WriteLine(t2);
            Console.ReadLine();
        }
    }
}
