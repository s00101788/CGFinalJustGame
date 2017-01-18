using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using GameClassLibrary;
using System.Collections.Generic;
using System;

namespace CGFinalJustGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        #region Declar

        static Random r = new Random();
        bool gameStarted = false;

        string clientID;
        Color playerColor = Color.Green;
        Color enemyColor = Color.Red;

        enum currentDisplay { Selection, Game, Score };
        currentDisplay currentState = currentDisplay.Selection;

        enum endGameStatuses { Win, Lose, Draw }
        endGameStatuses gameOutcome = endGameStatuses.Draw;

        Player player;
        Player Enemy;

        Menu menu;
        string[] menuOptions = new string[] { "Fast", "Normal", "Strong" };

        Vector2 startVector = new Vector2(50, 250);

        Bullet newBullet;

        Texture2D backgroundTexture;
        Texture2D[] textures;
        Texture2D textureCollectable;
        Texture2D textureSuperCollectable;
        Texture2D[] textureBarrier;
        Texture2D texHealth;
        SpriteFont message;

        KeyboardState oldState, newState;

        public List<Bullet> Bullets = new List<Bullet>();
        List<Collectable> Collectables = new List<Collectable>();
        List<Barrier> Barriers = new List<Barrier>();
        List<Collectable> pickUp = new List<Collectable>();
        List<Barrier> destroyBarrier = new List<Barrier>();
        List<Bullet> destroyBullets = new List<Bullet>();




        //static IHubProxy proxy;
        //HubConnection connection = new HubConnection("http://localhost:5553/");

        #endregion


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
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

            // TODO: use this.Content to load your game content here
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

            base.Draw(gameTime);
        }
    }
}
