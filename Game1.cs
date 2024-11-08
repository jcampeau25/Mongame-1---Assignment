using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mongame_1___Assignment
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D backgroundTexture, kanyeTexture, kendrickTexture;
        

        List<string> backgrounds = new List<string> { "beach", "forest", "nightsky"};

        Random generator = new Random();

        
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferWidth = 600;
            _graphics.PreferredBackBufferHeight = 400;
            _graphics.ApplyChanges();


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            int background = generator.Next(0, backgrounds.Count);
            

            backgroundTexture = Content.Load<Texture2D>(backgrounds[background]);
            kanyeTexture = Content.Load<Texture2D>("kanye");
            kendrickTexture = Content.Load<Texture2D>("kendrick");


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(backgroundTexture, new Vector2(0, 0), Color.White);

            _spriteBatch.Draw(kanyeTexture, new Rectangle (10, 150, 250, 300), Color.White);
            _spriteBatch.Draw(kendrickTexture, new Rectangle (200, 150, 300, 320), Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
