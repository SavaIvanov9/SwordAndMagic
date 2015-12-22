using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SwordAndMagic.Objects.TileLoader
{
    public class VisualTile : Tile
    {
        public VisualTile(char c, Rectangle collisionBox)
        {
            this.TileTexture = Content.Load<Texture2D>("Textures/floor2");
            this.Rectangle = collisionBox;
        }
    }
}
