using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    internal class Carrier:Warship
    {
        private int _people;
        public int People
        {
            get => _people;
            set => _people = value <= 5000 ? value : 5000;
        }
       
        public Carrier( string name ,int carryingCapacity, int guns, int people)  : base(name,carryingCapacity, guns) 
        { 
            this.Name = name;
            this.CarryingCapacity = carryingCapacity;
            this.Guns = guns;
            People = people;
        }
        public override void Write()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Name of carrier: {0}.\nThis warship have {1} guns.\n Carrying capacity: {2}.\n Max number of people: {3}",Name, Guns, CarryingCapacity, People);
            Console.WriteLine("----------------------------");
        }
    }
}
