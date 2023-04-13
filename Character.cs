using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L3_Containment_Aggregation
{
    internal class Character
    {
        string _name;
        int _weight;

        public Character(int weight, string name)
        {
            _weight = weight;
            _name = name;
        }

        public int Weight { get => _weight; set => _weight = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
