using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework.Content;
using SwordAndMagic.Interfaces;
using SwordAndMagic.States;

namespace SwordAndMagic.Managers
{
    using SwordAndMagic;
    public class StateManager : IContent
    {
        
        private State currentState;
        private ContentManager contentManager;

        public StateManager()
        {
            this.CurrentState = new MenuState();
            this.ContentManager = GameEngine.Engine.ContentLoader.Content;
        }

        public State CurrentState
        {
            get { return currentState; }
            set { currentState = value; }
        }

        public ContentManager ContentManager
        {
            get { return contentManager; }
            set { contentManager = value; }
        }

        public ContentManager Content { get; }
    }
}
