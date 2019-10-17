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

        protected Texture2D texture; //Texture
        protected Vector2 posision; //Spawn point

        //==========================================================================
        //===Konstructor for objects
        public GameObject(Texture2D texture, float X, float Y)
        {

            this.texture = texture;
            this.posision.X = X;
            this.posision.Y = Y;
            
        }

        //=========================================================================
        //===Draws object using texture & spawn point
        public void Draw(SpriteBatch spriteBach)
        {

            spriteBach.Draw(texture, posision, Color.White);

        }

        //==========================================================================
        //===Properties of object
        public float X { get { return posision.X; } }
        public float Y { get { return posision.Y; } }
        public float Width { get { return texture.Width; } }
        public float Height { get { return texture.Height; } }
    }

    //====================================================================================================================================================
    //===Moving object
    class MovingObject : GameObject
    {

        protected Vector2 speed; //Speed

        //==========================================================================
        //===Konstructor for moving object
        public MovingObject(Texture2D texture, float X, float Y, float speedX, float speedY) : base(texture, X, Y)
        {

            this.speed.X = speedX;
            this.speed.Y = speedY;

        }


    }
}
