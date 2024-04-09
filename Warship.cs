using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    internal class Warship:IShip
    {
        public string Name { get; set; }
        public int CarryingCapacity { get; set; }
        public int Guns { get; set; }
        public Warship() 
        {
            Name = "Warship";
            CarryingCapacity = 0;
            Guns = 0;
        }
        public Warship(string name ,int carryingCapacity, int guns)
        {
            Name = name;
            CarryingCapacity = carryingCapacity;
            Guns = guns;
        }
        public virtual void Write()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Name of warship: {0}.\nThis warship have {1} guns.\n Carrying capacity is {2}",Name, Guns, CarryingCapacity);
            Console.WriteLine("----------------------------");
        }

    }
}
