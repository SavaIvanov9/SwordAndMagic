using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Console.Interfaces;

namespace RPG_Console.Characters
{
    class Demon : Character, IAttack, IDestroyable, ICharacter
    {
            private const int DemonDmg = 100;
            private const int DemonHp = 150;
            private const char DemonSymbol = 'e';

            public Demon(Position position, string name)
                : base(position, DemonSymbol, name, DemonDmg, DemonHp)
            {
            }
        }
    }
