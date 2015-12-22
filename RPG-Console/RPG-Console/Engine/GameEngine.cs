using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Console.Engine
{
    using Interfaces;
    using Items;

    public class GameEngine
    {
        public const int MapWidth = 5;
        public const int MapHeight = 5;
        
        private IInputReader reader;
        private IRender render;

        public GameEngine(IInputReader reader, IRender render)
        {
            //this.reader = reader;
            //this.render = render;
            //this.characters = new List<GameObject>();
            //this.items = new List<GameObject>();
        }

        public void Run()
        {

        }
    }
}
