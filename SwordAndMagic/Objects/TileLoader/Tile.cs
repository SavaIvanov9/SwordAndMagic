using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SwordAndMagic.Objects;

namespace SwordAndMagic.Objects.TileLoader
{
    public abstract class Tile : GameObj
    {
        protected Texture2D TileTexture;
        private Rectangle rectangle;
        private static ContentManager content;

        public Rectangle Rectangle
        {
            get { return this.rectangle; }
            protected set { this.rectangle = value; }
        }

        public static ContentManager Content
        {
            protected get { return content; }
            set { content = value; }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.TileTexture, this.rectangle, Color.White);
        }
    }
}
   