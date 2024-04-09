using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    internal class CruiseLiner:PassengerShip
    {
        private int _people;
        public int People
        {
            get => _people;
            set => _people = value <= 8000 ? value : 8000;
        }

        public CruiseLiner(string name, int carryingCapacity, int people) : base(name, carryingCapacity)
        {
            this.Name = name;
            this.CarryingCapacity = carryingCapacity;
            People = people;
        }
        public override void Write()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Name of cruise liner: {0}.\n Carrying capacity: {1}.\n Max number of people: {2}", Name, CarryingCapacity, People);
            Console.WriteLine("----------------------------");
        }
    }
}
