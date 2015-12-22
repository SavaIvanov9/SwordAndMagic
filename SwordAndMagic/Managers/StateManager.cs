using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using SwordAndMagic.GameEngine;
using SwordAndMagic.Interfaces;
using SwordAndMagic.States;

namespace SwordAndMagic.Managers
{
    using SwordAndMagic;
    public class StateManager : IContent
    {
        
        private State currentState;
        private ContentManager contentManager;
        private GraphicsDeviceManager graphics;

        public StateManager(ContentManager content, GraphicsDeviceManager graphics)
        {
            this.CurrentState = new GameState(this.Content, graphics);
            //this.ContentManager = Engine.ContentManager.Content;
            this.Graphics = graphics;
        }

        public State CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }

        public GraphicsDeviceManager Graphics
        {
            get { return this.graphics; }
            set { this.graphics = value; }
        }

        public ContentManager ContentManager
        {
            get { return contentManager; }
            set { contentManager = value; }
        }



        public ContentManager Content { get; set; }
    }
}
