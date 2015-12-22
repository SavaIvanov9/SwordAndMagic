using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SwordAndMagic.Exceptions;
using SwordAndMagic.Map;

namespace SwordAndMagic.Objects
{
    public abstract class GameObject
    {
        public static ContentManager Content { get; set; }


        //private Position position;
        //private char objectSymbol;

        //protected GameObject(Position position, char objectSymbol)
        //{
        //    this.Position = position;
        //    this.ObjectSymbol = objectSymbol;
        //}

        //public Position Position
        //{
        //    get
        //    {
        //        return this.position;
        //    }

        //    set
        //    {
        //        if (value.X < 0
        //            || value.Y < 0
        //            || value.X >= GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width
        //            || value.Y >= GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height)
        //        {
        //            throw new ObjectOutOfBoundsException("Specified coordinates are outside map.");
        //        }

        //        this.position = value;
        //    }
        //}

        //public char ObjectSymbol
        //{
        //    get
        //    {
        //        return this.objectSymbol;
        //    }

        //    set
        //    {
        //        if (!char.IsUpper(value))
        //        {
        //            throw new ArgumentOutOfRangeException(
        //                "objectSymbol",
        //                "Object symbol must be an upper-case letter.");
        //        }

        //        this.objectSymbol = value;
        //    }
        //}
    }
}
