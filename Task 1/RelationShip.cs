using System.Collections.Generic;

namespace Task_1
{
    public static class RelationShip
    {
        private static Dictionary<(Person, Person), string> _relationShips = new Dictionary<(Person, Person), string>();

        public static void Is(this Person person1, string relation, Person person2)
        {
            _relationShips.Add((person1, person2), relation);
        }

        //get all the relationships
        public static Dictionary<(Person, Person), string> GetAllRelationShips()
        {
            return _relationShips;
        }
    }
}