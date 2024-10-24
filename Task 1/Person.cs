namespace Task_1
{
    public class Person
    {
        private string _name;
        private int _age;
        private string _profession;
        private Town _currentTown;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string profession, string name, int age)
        {
            Name = name;
            Age = age;
            Profession = profession;
        }

        public Person(string profession, string name, int age, Town currentTown)
        {
            Name = name;
            Age = age;
            Profession = profession;
            CurrentTown = currentTown;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }


        public Town CurrentTown
        {
            get => _currentTown;
            set
            {
                if(_currentTown != null) _currentTown.RemovePerson(this);
                _currentTown = value;
                _currentTown.AddPerson(this);
            }
        }

        public string Profession
        {
            get => _profession;
            set => _profession = value;
        }

        public override string ToString()
        {
            return $"Name: {_name}, Age: {_age}, Profession: {_profession}, {_currentTown}";
        }
    }
}