﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwordAndMagic.Interfaces
{
    public interface IAttack
    {
        int Damage { get; set; }

        void Attack(ICharacter enemy);
    }
}
