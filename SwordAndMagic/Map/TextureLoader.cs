using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SwordAndMagic.Map
{
    public static class TextureLoader
    {
        public static Texture2D Hero { get; set; }
        public static Texture2D Wall { get; set; }
        public static Texture2D Floor { get; set; }
        public static Texture2D Background { get; set; }

        public static void Load(ContentManager content)
        {
            Hero = content.Load<Texture2D>("Content/Textures/Player1");
            Wall = content.Load<Texture2D>("Content/Textures/wall4");
            Floor = content.Load<Texture2D>("Content/Textures/grass2");
            Background = content.Load<Texture2D>("Content/Textures/background");

        }
    }
}
