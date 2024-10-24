using System.Collections.Generic;

namespace Task_1
{
    public class Town
    {
        private string _name;
        private string _city;
        private string _postalcode;
        private List<Person> persons = new List<Person>();

        public Town()
        {
        }

        public Town(string name)
        {
            _name = name;
        }

        public Town(string city, string name, string postalcode)
        {
            _city = city;
            _name = name;
            _postalcode = postalcode;
        }

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public void RemovePerson(Person person)
        {
            persons.Remove(person);
        }

        public List<Person> GetPersons()
        {
            return persons;
        }

        public override string ToString()
        {
            return $"Town: {_name}, City: {_city}, Postal Code: {_postalcode}";
        }
    }
}