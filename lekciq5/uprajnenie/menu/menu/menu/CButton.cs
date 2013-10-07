using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace menu
{
    public class CButton 
    {
        Texture2D texture;
        Vector2 position;
        Rectangle rectangle;
        Color color = new Color(255,255,255,255);
        public Vector2 size;
        public CButton(Texture2D newTexture,GraphicsDevice graphics)
        {
            this.texture = newTexture;
            size = new Vector2(graphics.Viewport.Width / 6, graphics.Viewport.Height / 5);
        }
        bool down;
        public bool isClicked;
        public void Update(MouseState mouse)
        {
            rectangle = new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
            Rectangle mouseRect = new Rectangle(mouse.X, mouse.Y, 1, 1);
            if (mouseRect.Intersects(rectangle))
            {
                if (color.A == 255)
                {
                    down = false;
                }
                if (color.A == 0)
                {
                    down = true;
                }
                if (down ==  true)
                {
                    color.A += 3;
                }
                else
                {
                    color.A -= 3;
                }
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    isClicked = true;
                }
            }
            else if(color.A <255)
            {
                color.A += 3;
                isClicked = false;
            }
        }
        public void SetPositionOfButton(Vector2 newPosition)
        {
            this.position = newPosition;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, color);
        }
        public void DrawButton(GameState currentGamestate, SpriteBatch spriteBatch, ContentManager Content, int WindowWidth, int WindowHeight)
        {
            switch (currentGamestate)
            {
                case GameState.MainMenu:
                    spriteBatch.Draw(Content.Load<Texture2D>("background41"), new Rectangle(0, 0, WindowWidth, WindowHeight), Color.White);
                    Draw(spriteBatch);
                    break;
                case GameState.Playing:
                    break;
            }
        }
    }
}
