using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPACESHOOTER
{
    /// <summary>
    /// This is the main type for your game.henrik
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Player player;
        List<Enemy> enemies;
        PrintText printText;
                      
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

       
        protected override void Initialize() //INITIALIZE-------------------------------------------
        {
                    base.Initialize();
        }

      
        protected override void LoadContent() //LOADCONTENT--------------------------
        {
           
            spriteBatch = new SpriteBatch(GraphicsDevice);

            player = new Player(Content.Load<Texture2D>("Sprites/ship"), 380, 400, 14f, 14f);

            //enemy start
            enemies = new List<Enemy>();  Random random = new Random();
            Texture2D tmpSprite = Content.Load<Texture2D>("Sprites/mine");
            for (int i = 0; i < 10; i++)
            {
                int rndX = random.Next(0, Window.ClientBounds.Width - tmpSprite.Width);
                int rndY = random.Next(0, Window.ClientBounds.Height / 2);
                Enemy temp = new Enemy(tmpSprite, rndX, rndY);
                enemies.Add(temp); //adds it to list
            }
            //enemy end

            printText = new PrintText(Content.Load<SpriteFont>("Sprites/myfont"));

        }

        
        protected override void UnloadContent()
        {
         


        }


        protected override void Update(GameTime gameTime) //UPDATE-----------------------------------------------------------
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            player.Update(Window);
            foreach (Enemy e in enemies.ToList())
            {
                if (e.IsAlive)
                {
                    if (e.CheckCollection(player))
                        this.Exit();
                    e.Update(Window);
                }                  
                else
                    enemies.Remove(e);
            }
           
        }


        protected override void Draw(GameTime gameTime) //DRAW------------------------------------------------------------
        {
            GraphicsDevice.Clear(Color.Black);
                   
            spriteBatch.Begin();

            player.Draw(spriteBatch);

            foreach (Enemy e in enemies) e.Draw(spriteBatch);

            printText.Print("Antal fiender" + enemies.Count, spriteBatch, 0, 0);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
