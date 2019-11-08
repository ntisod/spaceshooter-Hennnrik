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
    class Enemy : PhysicalObject
    {

        bool isAlive= true;

        public Enemy(Texture2D texture, float X, float Y) : base(texture, X, Y, 6f, 0.3f)
        {



        }

        public void Update(GameWindow window)
        {

            //Moves the enemy
            posision.X += speed.X;

            //Stops enemy from leaving (side to side) and switches directions
            if (posision.X > window.ClientBounds.Width - texture.Width || posision.X < 0) speed.X *= -1;
            posision.Y += speed.Y;

            //inactivates enemy once its past screan
            if (posision.Y > window.ClientBounds.Height) isAlive = false;

        }

        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value;  }
        }
    }
}
