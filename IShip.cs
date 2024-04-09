using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    internal interface IShip
    {
        string Name { get; set; }
        int CarryingCapacity { get; set; }
        void Write();
    }
}
