using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L3_Containment_Aggregation
{
    internal class Suspension
    {
        float _frontBalance;
        float _springyNess;
        float _rearBalance;

        public Suspension(float frontBalance, float springyNess, float rearBalance)
        {
            _frontBalance = frontBalance;
            _springyNess = springyNess;
            _rearBalance = rearBalance;
        }

        public float FrontBalance { 
            get => _frontBalance; 
            
            // | -1 to 1: 0 is centered, -1 is left balance, 1 is right
            set {
                if(value >= -1 && value <= 1)
                {
                    _frontBalance = value;
                }
            } 
        }

        public float SpringyNess { get => _springyNess; set => _springyNess = value; }
        public float RearBalance { get => _rearBalance; set => _rearBalance = value; }
    }
}
