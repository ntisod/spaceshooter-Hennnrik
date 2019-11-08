using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPACESHOOTER
{
    class Player : PhysicalObject
    {

        int points = 0;



        public Player(Texture2D texture, float X, float Y, float speedX, float speedY) : base (texture, X, Y, speedX, speedY)
        {

        }
        //UPPDATE________________________________________________________________
        public void Update(GameWindow window)
        {

            KeyboardState keyboardState = Keyboard.GetState();


            if (posision.X <= window.ClientBounds.Width - texture.Width && posision.X >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.Right))
                    posision.X += speed.X;
                if (keyboardState.IsKeyDown(Keys.Left))
                    posision.X -= speed.X;
            }

            if (posision.Y <= window.ClientBounds.Height - texture.Height && posision.Y >= 0)
            {
                if (keyboardState.IsKeyDown(Keys.Down))
                    posision.Y += speed.Y;
                if (keyboardState.IsKeyDown(Keys.Up))
                    posision.Y -= speed.Y;
            }

            if (posision.X < 0)
                posision.X = 0;

            if (posision.X > window.ClientBounds.Width - texture.Width)
            {
                posision.X = window.ClientBounds.Width - texture.Width;
            }

            if (posision.Y < 0)
                posision.Y = 0;

            if (posision.Y > window.ClientBounds.Height - texture.Height)
            {
                posision.Y = window.ClientBounds.Height - texture.Height;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {

           spriteBatch.Draw(texture, posision, Color.White);

        }
        
    }
}
