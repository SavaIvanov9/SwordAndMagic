using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SwordAndMagic.GameEngine;
using SwordAndMagic.Map;

namespace SwordAndMagic.Objects.TileLoader
{
    public class CollidableTile : Tile
    {
        
        public CollidableTile(char c, Rectangle newRectangle)
        {
            this.TileTexture = Content.Load<Texture2D>("Textures/wall4");
            this.Rectangle = newRectangle;
        }

    }
}
