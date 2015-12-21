using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwordAndMagic.Objects.Items;

namespace SwordAndMagic.Interfaces
{
    public interface ICollect
    {
        IEnumerable<Item> Inventory { get; }

        void AddItemToInventory(Item item);
    }
}
