using System.ComponentModel.Design;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SwordAndMagic.Map;

namespace SwordAndMagic.GameEngine
{
    using Managers;
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Engine : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Vector2 mPosition = new Vector2(0,0);
        Vector2 ObjPosCounter = new Vector2(0,0);
        Vector2 Velocity = new Vector2(0, 0);
        Texture2D mOptions;
        public static ContentLoader ContentLoader;

        public Engine()
        {
            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = 1024;
            graphics.PreferredBackBufferHeight = 768;

            this.Window.AllowUserResizing = false;
            this.IsMouseVisible = false;

            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            TextureLoader.Load(this.Content);

            // TODO: use this.Content to load your game content here
            mOptions = this.Content.Load<Texture2D>("Menu/options");

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            //MouseState mouseState = Mouse.GetState();

            //if (Mouse.GetState().LeftButton == ButtonState.Pressed && mOptions.Bounds.Contains(Mouse.GetState().Position))
            //{
            //    Exit();
            //}

            //Velocity = Vector2.Zero;

            //if(Keyboard.GetState().IsKeyDown(Keys.Right))
            //{
            //    Velocity = new Vector2(0, 1);
            //}
            //if(Keyboard.GetState().IsKeyDown(Keys.Left))
            //{
            //    Velocity = new Vector2(0, -1);
            //}
            

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            spriteBatch.Draw(TextureLoader.Background, new Rectangle(0, 0, graphics.GraphicsDevice.Viewport.Width, graphics.GraphicsDevice.Viewport.Height), Color.White);

            MapLoader mapMatrix = new MapLoader();
            char[,] map1 = mapMatrix.ReadMap("map1.1.txt");

            for (int i = 0; i < map1.GetLength(0); i++)
            {
                for (int j = 0; j < map1.GetLength(1); j++)
                {
                    if (map1[i, j] == 'p')
                    {
                        
                        spriteBatch.Draw(TextureLoader.Hero, new Vector2(j * 30, i * 30), Color.White);
                        
                    }

                    else if (map1[i, j] == 'f')
                    {
                        spriteBatch.Draw(TextureLoader.Floor, new Vector2(j * 30, i * 30), Color.White);
                    }

                    else if (map1[i, j] == 'w')
                    {
                        spriteBatch.Draw(TextureLoader.Wall, new Vector2(j * 30, i * 30), Color.White);
                    }

                    else if (map1[i, j] == 's')
                    {
                        spriteBatch.Draw(TextureLoader.Sword, new Vector2(j * 30, i * 30), Color.White);
                    }
                    else if (map1[i, j] == 'o')
                    {
                        spriteBatch.Draw(TextureLoader.DoorOpened, new Vector2(j * 30, i * 30), Color.White);
                    }
                    else if (map1[i, j] == 't')
                    {
                        spriteBatch.Draw(TextureLoader.Teleport, new Vector2(j * 30, i * 30), Color.White);
                    }
                }
            }

            MapLoader mapMatrix2 = new MapLoader();
            char[,] map2 = mapMatrix2.ReadMap("map1.2.txt");

            for (int i = 0; i < map2.GetLength(0); i++)
            {
                for (int j = 0; j < map2.GetLength(1); j++)
                {
                    if (map2[i, j] == 'p')
                    {
                        if (Keyboard.GetState().IsKeyDown(Keys.Right))
                        {
                            Velocity.X += 200 * (float)gameTime.ElapsedGameTime.TotalSeconds;
                            
                        }
                        if (Keyboard.GetState().IsKeyDown(Keys.Left))
                        {
                            Velocity.X -= 200 * (float)gameTime.ElapsedGameTime.TotalSeconds;

                        }
                        if (Keyboard.GetState().IsKeyDown(Keys.Up))
                        {
                            Velocity.Y -= 200 * (float)gameTime.ElapsedGameTime.TotalSeconds;

                        }
                        if (Keyboard.GetState().IsKeyDown(Keys.Down))
                        {
                            Velocity.Y += 200 * (float)gameTime.ElapsedGameTime.TotalSeconds;

                        }
                        spriteBatch.Draw(TextureLoader.Hero, new Vector2(j * 30 + Velocity.X, i * 30 + Velocity.Y), Color.White);
                        //spriteBatch.Draw(TextureLoader.Hero, new Vector2(j * 30, i * 30), Color.White);
                    }

                    else if (map2[i, j] == 'f')
                    {
                        spriteBatch.Draw(TextureLoader.Floor, new Vector2(j * 30, i * 30), Color.White);
                    }

                    else if (map2[i, j] == 'w')
                    {
                        spriteBatch.Draw(TextureLoader.Wall, new Vector2(j * 30, i * 30), Color.White);
                    }

                    else if (map2[i, j] == 's')
                    {
                        spriteBatch.Draw(TextureLoader.Sword, new Vector2(j * 30, i * 30), Color.White);
                    }
                    else if (map2[i, j] == 'o')
                    {
                        spriteBatch.Draw(TextureLoader.DoorOpened, new Vector2(j * 30, i * 30), Color.White);
                    }
                    else if (map2[i, j] == 't')
                    {
                        spriteBatch.Draw(TextureLoader.Teleport, new Vector2(j * 30, i * 30), Color.White);
                    }
                }
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
