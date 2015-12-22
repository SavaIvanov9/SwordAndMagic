using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SwordAndMagic.Characters.Hero
{
    public class Hero : Player.Player
    {
        //private RangedWeapon currentWeapon;
        //private int currentWeaponAmmo;

        public Hero(int health, float damage, string name, ContentManager content) 
            : base(health, damage, name)
        {
            this.Image = content.Load<Texture2D>("Textures/Player1");
            Initialize();
        }

        public bool IsAttacking { get; set; }

        private void Initialize()
        {
            //this.currentWeapon = new Pistol();
            //this.currentWeaponAmmo = 50;
        }

        public override void Attack(Character enemy)
        {
            if (this.IsAttacking)
            {

            }
        }
    }
}
