using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Console.Interfaces
{
    using Characters;
    public interface IPlayer : ICharacter, IMoveable, ICollect
    {
        PlayerClass Playerclass { get; }
    }
}
