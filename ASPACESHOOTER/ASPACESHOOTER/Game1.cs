using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

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

        }

        
        protected override void UnloadContent()
        {
         


        }


        protected override void Update(GameTime gameTime) //UPDATE-----------------------------------------------------------
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            player.Update(Window);

           
        }


        protected override void Draw(GameTime gameTime) //DRAW------------------------------------------------------------
        {
            GraphicsDevice.Clear(Color.Black);
                   
            spriteBatch.Begin();

            player.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
