﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Console.Items
{
    using Exceptions;
    using Engine;
    public abstract class GameObject
    {
        private Position position;
        private char objectSymbol;

        protected GameObject(Position position, char objectSymbol)
        {
            this.Position = position;
            this.ObjectSymbol = objectSymbol;
        }

        public Position Position
        {
            get
            {
                return this.position;
            }

            set
            {
                // Added upper-bound check
                if (value.X < 0
                    || value.Y < 0
                    || value.X >= GameEngine.MapWidth
                    || value.Y >= GameEngine.MapHeight)
                {
                    throw new OutOfBoundsException("Specified coordinates are outside map.");
                }

                this.position = value;
            }
        }

        public char ObjectSymbol
        {
            get
            {
                return this.objectSymbol;
            }

            set
            {
                if (!char.IsUpper(value))
                {
                    throw new ArgumentOutOfRangeException(
                        "objectSymbol",
                        "Object symbol must be an upper-case letter.");
                }

                this.objectSymbol = value;
            }
        }
    }
}
