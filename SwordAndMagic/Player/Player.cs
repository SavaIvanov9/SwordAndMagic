using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using SwordAndMagic.Interfaces;
using SwordAndMagic.Map;
using SwordAndMagic.Objects.Items;


namespace SwordAndMagic.Player
{
    using Characters;

    public abstract class Player : Character
    {
        private int score;
        private decimal money;
        private string name;

        protected Player(int health, float damage, string name)
            : base(health, damage)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (!IsValidName(value))
                {
                    throw new ArgumentException("Invalid symbols in name");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }

        public bool IsMovingLeft { get; set; }
        public bool IsMovingRight { get; set; }
        public bool IsMovingUp { get; set; }
        public bool IsMovingDown { get; set; }

        public abstract override void Attack(Character enemy);

        public override void Update(GameTime gameTime)
        {
            this.Move();
            base.Update(gameTime);
        }

        public void Move()
        {
            if (this.IsMovingDown)
            {
                this.PositionY += 2;
                this.IsMovingDown = false;
            }
            else if (this.IsMovingUp)
            {
                this.PositionY -= 2;
                this.IsMovingUp = false;
            }
            else if (this.IsMovingLeft)
            {
                this.PositionX -= 2;
                this.IsMovingLeft = false;
            }
            else if (this.IsMovingRight)
            {
                this.PositionX += 2;
                this.IsMovingRight = false;
            }
        }

        private bool IsValidName(string name)
        {
            name = name.ToUpper();

            return name.All(ch => ch >= 65 && ch <= 90);
        }

        //private readonly List<Item> inventory;

        //public Player(Position position, char objectSymbol, string name, PlayerClass type)
        //    : base(position, objectSymbol, name, 0, 0)
        //{
        //    this.Type = type;
        //    this.inventory = new List<Item>();
        //    this.SetPlayerStats();
        //}

        //public PlayerClass Type { get; private set; }

        //public IEnumerable<Item> Inventory
        //{
        //    get
        //    {
        //        return this.inventory;
        //    }
        //}

        //public void Move(string direction)
        //{
        //}

        //public void AddItemToInventory(Item item)
        //{
        //    this.inventory.Add(item);
        //}

        //public void Heal()
        //{
        //    var healPotion = this.inventory.FirstOrDefault() as HealthPotion;

        //    if (healPotion == null)
        //    {
        //        //throw new NotEnoughBeerException("Not enough beer!!!");
        //    }

        //    this.Health += healPotion.HealthRestore;
        //    this.inventory.Remove(healPotion);
        //}

        //private void SetPlayerStats()
        //{
        //    switch (this.Type)
        //    {
        //        case PlayerClass.Mage:
        //            this.Damage = 100;
        //            this.Health = 150;
        //            break;
        //        case PlayerClass.Warrior:
        //            this.Damage = 50;
        //            this.Health = 300;
        //            break;
        //        default:
        //            throw new ArgumentException("Unknown player race.");
        //    }
        //}
    }
}
