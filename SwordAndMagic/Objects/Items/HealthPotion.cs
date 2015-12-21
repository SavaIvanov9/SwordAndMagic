using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwordAndMagic.Map;

namespace SwordAndMagic.Objects.Items
{
    public class HealthPotion : Item
    {
        private const char HealthSymbol = 'h';

        public HealthPotion(Position position, HealthPotionSize healthSize)
            : base(position, HealthSymbol)
        {
            this.HealthPotionSize = healthSize;
        }

        public int HealthRestore
        {
            get
            {
                return (int)this.HealthPotionSize;
            }
        }

        private HealthPotionSize HealthPotionSize { get; set; }
    }
}
