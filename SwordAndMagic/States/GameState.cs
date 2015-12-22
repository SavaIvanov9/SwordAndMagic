using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SwordAndMagic.Managers;

namespace SwordAndMagic.States
{
    public class GameState : State
    {
        //private Santa player;
        //private Thief enemy;

        private readonly LevelManager levelManager;
        //private SpriteFont font;
        //private Texture2D SideMenu;

        //private Viewport MapViewport;
        //private Viewport MenuViewport;
        //private Viewport InventoryViewport;

        public GameState(ContentManager content, GraphicsDeviceManager graphics)
        {
            base.Content = content;
            this.levelManager = new LevelManager();
            this.Graphics = graphics;
            Initialize();
        }

        private void Initialize()
        {
            //this.player = new Santa(100, 100, "Pesho", this.Content);
            //this.enemies = new List<Thief>()
            //{
            //    new Thief(this.Content)
            //};
            //this.enemies[0].Killed += EnemyKilled;


            //this.giftFactory = new GiftFactory();

            //this.player.PositionX = 36;
            //this.player.PositionY = 36;

            //this.font = this.Content.Load<SpriteFont>("Fonts/mainMenu");
            //this.SideMenu = this.Content.Load<Texture2D>("Images/Backgrounds/SideMenu");

            //this.MapViewport = new Viewport
            //{
            //    X = 420,
            //    Y = 0,
            //    Width = this.Graphics.PreferredBackBufferHeight,
            //    Height = this.Graphics.PreferredBackBufferHeight,
            //    MinDepth = 0,
            //    MaxDepth = 1
            //};
        }

        public override void Draw (SpriteBatch spriteBatch)
            {
            Viewport original = this.Graphics.GraphicsDevice.Viewport;
            spriteBatch.Begin();
            this.levelManager.CurrentLevel.Draw(spriteBatch);
            //this.player.Draw(spriteBatch);


            spriteBatch.End();
            }

        public override void Update (GameTime gameTime)
            {

            }

        }
    }