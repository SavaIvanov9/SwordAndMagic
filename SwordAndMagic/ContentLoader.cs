using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using SwordAndMagic.Interfaces;

namespace SwordAndMagic
{
    public class ContentLoader : IContent
    {
        private ContentManager content;

        public ContentLoader(ContentManager content)
        {
            this.content = content;
        }

        public ContentManager Content
        {
            get { return this.content; }
            set { this.content = value; }
        }
    }
}
