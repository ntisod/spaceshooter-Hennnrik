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
    class GameObject
    {

        Texture2D gfx;
        Vector2 posision;

        public GameObject(Texture2D gfx, float X, float Y)
        {

            this.gfx = gfx;
            this.posision.X = X;


        }

        public void Draw(SpriteBatch spriteBach)
        {
            

        }
    }
}
