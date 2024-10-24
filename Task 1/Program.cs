using System;
using System.Collections.Generic;

namespace Task_1
{
    internal abstract class Program
    {
        static void Main(string[] args)
        {
            PersonTownExample(out var chittagongTown, out var bush, out var pirojpurTown, out var fahim);
            FriendExample(bush, fahim);
            ChangeTownExample(bush, pirojpurTown);
            Console.ReadLine();
        }

        private static void PersonTownExample(out Town chittagongTown, out Person bush, out Town pirojpurTown,
            out Person fahim)
        {
            Console.WriteLine("Person and Town Example");
            chittagongTown = new Town("Bhoso", "Chittagong", "B488D");
            bush = new Person("Doctor", "Bush", 25, chittagongTown);

            pirojpurTown = new Town("Pirojpur", "Kadamata", "B420D");
            fahim = new Person("Engineer", "Fahim", 25, pirojpurTown);

            Console.WriteLine(bush);
            Console.WriteLine(fahim);
            Console.WriteLine();
        }

        private static void FriendExample(Person bush, Person fahim)
        {
            Console.WriteLine("Friend Example");
            bush.Is("Super smart Friend", fahim);
            fahim.Is("Also super smart Friend", bush);

            foreach (KeyValuePair<(Person, Person), string> item in RelationShip.GetAllRelationShips())
            {
                Console.WriteLine($"{item.Key.Item1.Name} is {item.Value} of {item.Key.Item2.Name}");
            }

            Console.WriteLine();
        }


        private static void ChangeTownExample(Person bush, Town pirojpurTown)
        {
            Console.WriteLine("Change Town Example");
            bush.CurrentTown = pirojpurTown;
            Console.WriteLine(bush);

            foreach (Person person in pirojpurTown.GetPersons())
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
        }
    }
}