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
            Person p = new Person(t2,"Bush",25,"Son");
            Console.WriteLine(p.town.city);
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
