using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L3_Containment_Aggregation
{
    internal class GoKart
    {

        Engine _engine;
        Character _playerCharacter;

        public GoKart(Character playerCharacter)
        {
            _playerCharacter = playerCharacter;
            _engine = new Engine(250 - ( playerCharacter.Weight / 4));
            
        }

        internal Engine Engine1 { 
            get => _engine; 
        }

        public void TweakEngine(int newHp)
        {
            _engine.Hp = newHp;
        }

        public override string ToString()
        {
            return $"Character {_playerCharacter.Name} - Weight: {_playerCharacter.Weight} : Engine Hp {_engine.Hp} ";
        }


    }
}
