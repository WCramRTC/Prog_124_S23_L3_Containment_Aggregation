using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L3_Containment_Aggregation
{
    internal class Computer
    {
        // computer
        // cpu
        // motherboard
        // ram
        // power supply
        // fan
        // hard drive
        // graphics card

        string _cpu;
        string _mother;
        GraphicsCard _graphicsCard;

        public Computer(GraphicsCard graphicsCard)
        {
            _graphicsCard = graphicsCard;
        }

        // Difference Between Containment and Aggregation

    }
}
