using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace MonoGameAdventureGameForDesktop
{
    public class Button
    {
        public enum CurrentState { Up, Hover, Down }
        public SoundEffect ClickSound { get; set; }
        public CurrentState CurrentButtonState { get; set; }
        public Texture2D Image { get; set; }
        public Vector2 Location { get; set; }
        public event EventHandler Clicked;

        public Button(Texture2D image, Vector2 location, SoundEffect click = null)
        {
            Image = image;
            Location = location;
            ClickSound = click;
        }

        public void Update(GameTime gameTime)
        {
            if (!GetBoundary().Contains(MonoAdventureGame.CurrentMouseState.Position))
            {
                CurrentButtonState = CurrentState.Up;
                return;
            }

            if (MonoAdventureGame.CurrentMouseState.LeftButton == ButtonState.Pressed)
            {
                CurrentButtonState = CurrentState.Down;
                if (MonoAdventureGame.PreviousMouseState.LeftButton == ButtonState.Released)
                {
                    Clicked?.Invoke(this, EventArgs.Empty);
                    ClickSound?.Play();
                }
            }
            else { CurrentButtonState = CurrentState.Hover; }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Location, GetSourceRectangle(), Color.White);
        }

        public Rectangle GetBoundary()
        {
            return new Rectangle((int)Location.X, (int)Location.Y, Image.Width, Image.Height / 3);
        }

        protected Rectangle GetSourceRectangle()
        {
            int oneThirdImageHeight = Image.Height / 3;
            switch (CurrentButtonState)
            {
                case CurrentState.Up:
                    return new Rectangle(0, 0, Image.Width, oneThirdImageHeight);
                case CurrentState.Hover:
                    return new Rectangle(0, oneThirdImageHeight, Image.Width, oneThirdImageHeight);
                case CurrentState.Down:
                    return new Rectangle(0, oneThirdImageHeight * 2, Image.Width, oneThirdImageHeight);
                default:
                    return Rectangle.Empty;
            }

        }
    }
}