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
        public static Texture2D DoorOpened { get; set; }
        public static Texture2D Floor { get; set; }
        public static Texture2D Background { get; set; }
        public static Texture2D Sword { get; set; }
        public static Texture2D Teleport { get; set; }

        public static void Load(ContentManager content)
        {
            Hero = content.Load<Texture2D>("Textures/Player1");
            Wall = content.Load<Texture2D>("Textures/wall4");
            DoorOpened = content.Load<Texture2D>("Textures/doorOpened");
            Floor = content.Load<Texture2D>("Textures/floor2");
            Background = content.Load<Texture2D>("Textures/background3");
            Sword = content.Load<Texture2D>("Textures/sword-small");
            Teleport = content.Load<Texture2D>("Textures/r3");
        }
    }
}
