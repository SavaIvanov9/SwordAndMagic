using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SwordAndMagic.Map;
using SwordAndMagic.Objects;

namespace SwordAndMagic.Characters
{
    using Interfaces;
    public abstract class Character : GameObject
    {

        private Texture2D img;
        private int health;
        private float damage;
        private int positionX;
        private int positionY;
        private Rectangle collisionBox;
        private bool isAlive;

        protected Character(int health, float damage)
        {
            this.Damage = damage;
            this.Health = health;
        }

        protected Character() { }

        public Rectangle CollisionBox
        {
            get { return this.collisionBox; }
            protected set { this.collisionBox = value; }
        }

        public Texture2D Image
        {
            get { return this.img; }
            protected set { this.img = value; }
        }

        public int PositionX
        {
            get { return this.positionX; }
            set
            {
                this.positionX = value;
            }
        }

        public int PositionY
        {
            get { return this.positionY; }
            set
            {
                this.positionY = value;
            }
        }

        public bool IsAlive
        {
            get { return this.isAlive; }
            set { this.isAlive = value; }
        }

        public float Damage
        {
            get { return this.damage; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Player damage cannot be or negative");
                }
                this.damage = value;
            }
        }

        public int Health
        {
            get { return this.health; }
            protected set
            {
                this.isAlive = value > 0;

                this.health = value;
            }
        }

        public virtual void Update(GameTime gameTime)
        {
            this.CollisionBox = new Rectangle(this.PositionX, this.PositionY, this.Image.Width, this.Image.Height);
        }

        //public virtual void Collision(Rectangle newRectangle)
        //{
        //    if (this.CollisionBox.TouchRightOf(newRectangle))
        //    {
        //        this.PositionX = newRectangle.X + this.CollisionBox.Width;
        //    }
        //    if (this.CollisionBox.TouchLeftOf(newRectangle))
        //    {
        //        this.PositionX = newRectangle.X - this.CollisionBox.Width;
        //    }
        //    if (this.CollisionBox.TouchTopOf(newRectangle))
        //    {
        //        this.PositionY = newRectangle.Y - this.CollisionBox.Height;
        //    }
        //    if (this.CollisionBox.TouchBottomOf(newRectangle))
        //    {
        //        this.PositionY = newRectangle.Y + this.CollisionBox.Height;
        //    }
        //}

        public abstract void Attack(Character enemy);
        //private string name;

        //protected Character(Position position, char objectSymbol, string name, int damage, int health)
        //    : base(position, objectSymbol)
        //{
        //    this.Damage = damage;
        //    this.Health = health;
        //    this.Name = name;
        //}

        //public int Damage { get; set; }

        //public int Health { get; set; }

        //public string Name
        //{
        //    get
        //    {
        //        return this.name;
        //    }

        //    private set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentNullException("name", "Name cannot be null, empty or whitespace.");
        //        }

        //        this.name = value;
        //    }
        //}

        //public void Attack(ICharacter enemy)
        //{
        //    enemy.Health -= this.Damage;
        //}

    }
}
