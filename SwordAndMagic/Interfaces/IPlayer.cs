using System.Collections.Generic;
using SwordAndMagic.Characters;
using SwordAndMagic.Interfaces;
using SwordAndMagic.Objects.Items;
using SwordAndMagic.Player;

namespace SwordAndMagic.Interfaces
{

    public interface IPlayer : ICharacter, ICollect, IHeal
    {
        PlayerClass Type { get; }
    }
}
