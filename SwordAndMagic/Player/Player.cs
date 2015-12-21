using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SwordAndMagic.Interfaces;
using SwordAndMagic.Map;
using SwordAndMagic.Objects.Items;


namespace SwordAndMagic.Player
{
    using Characters;

    public abstract class Player : Character, IPlayer
    {
        private readonly List<Item> inventory;

        public Player(Position position, char objectSymbol, string name, PlayerClass type)
            : base(position, objectSymbol, name, 0, 0)
        {
            this.Type = type;
            this.inventory = new List<Item>();
            this.SetPlayerStats();
        }

        public PlayerClass Type { get; private set; }

        public IEnumerable<Item> Inventory
        {
            get
            {
                return this.inventory;
            }
        }

        public void Move(string direction)
        {
        }

        public void AddItemToInventory(Item item)
        {
            this.inventory.Add(item);
        }

        public void Heal()
        {
            var healPotion = this.inventory.FirstOrDefault() as HealthPotion;

            if (healPotion == null)
            {
                //throw new NotEnoughBeerException("Not enough beer!!!");
            }

            this.Health += healPotion.HealthRestore;
            this.inventory.Remove(healPotion);
        }

        private void SetPlayerStats()
        {
            switch (this.Type)
            {
                case PlayerClass.Mage:
                    this.Damage = 100;
                    this.Health = 150;
                    break;
                case PlayerClass.Warrior:
                    this.Damage = 50;
                    this.Health = 300;
                    break;
                default:
                    throw new ArgumentException("Unknown player race.");
            }
        }
    }
}
