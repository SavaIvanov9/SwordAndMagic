using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SwordAndMagic.States
{
    public class GameState : State
    {
        private Santa player;
        private Thief enemy;

        private readonly LevelManager levelManager;
        private SpriteFont font;
        private Texture2D SideMenu;

        private Viewport MapViewport;
        private Viewport MenuViewport;
        private Viewport InventoryViewport;
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();



            spriteBatch.End();
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
