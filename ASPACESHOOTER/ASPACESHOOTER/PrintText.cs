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
    class PrintText
    {
        SpriteFont font;

        public PrintText(SpriteFont font)
        {
            this.font = font;
        }

        public void Print(string text, SpriteBatch spriteBatch, int X, int Y)
        {

            spriteBatch.DrawString(font, text, new Microsoft.Xna.Framework.Vector2(X, Y), Color.White);

        }
    }
}
