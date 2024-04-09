using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    internal class PassengerShip:IShip
    {
        public string Name { get; set; }
        public int CarryingCapacity { get; set; }
        public PassengerShip()
        {
            Name = "Passenger ship";
            CarryingCapacity = 0;
        }
        public PassengerShip(string name, int carryingCapacity)
        {
            Name = name;
            CarryingCapacity = carryingCapacity;
            
        }
        public virtual void Write()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Name of passenger ship: {0}.\n Carrying capacity is {1}", Name, CarryingCapacity);
            Console.WriteLine("----------------------------");
        }

    }
}
