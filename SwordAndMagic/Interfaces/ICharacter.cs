using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwordAndMagic.Map;

namespace SwordAndMagic.Interfaces
{
    public interface ICharacter : IAttack, IDestroyable
    {
        string Name { get; }

        Position Position { get; }
    }
}
