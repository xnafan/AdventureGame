using AdventureGameClassLibrary;
using Challenge = AdventureGameClassLibrary.Challenge;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using System;

namespace MonoGameAdventureGameForDesktop
{
    public class MonoAdventureGame : Game
    {
        Challenge.GameController gameController = new Challenge.GameController();
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Song backgroundMusic;
        private SoundEffect clickSound, newGameSound, swordClashSound;
        private Texture2D background;
        private SpriteFont smallFont, font, bigFont;
        public static MouseState CurrentMouseState { get; set; }
        public static MouseState PreviousMouseState { get; set; }
        Button newGameButton, playRoundButton;
        public MonoAdventureGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            backgroundMusic = this.Content.Load<Song>("Audio/Fantasy_Choir_2");
            clickSound = this.Content.Load<SoundEffect>("Audio/Door close");
            newGameSound = this.Content.Load<SoundEffect>("Audio/Medieval Award");
            swordClashSound = this.Content.Load<SoundEffect>("Audio/Sword-clash-04");
            background = this.Content.Load<Texture2D>("Gfx/Background");
            MediaPlayer.Play(backgroundMusic);
            smallFont = Content.Load<SpriteFont>("Fonts/Smallfont");
            font = Content.Load<SpriteFont>("Fonts/font");
            bigFont = Content.Load<SpriteFont>("Fonts/Bigfont");

            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            //_graphics.IsFullScreen = true; 
            _graphics.ApplyChanges();

            newGameButton = new Button(Content.Load<Texture2D>("gfx/NewGameButtons"), new Vector2(_graphics.PreferredBackBufferWidth - 380, _graphics.PreferredBackBufferHeight - 150), clickSound);
            newGameButton.Clicked += NewGameButton_Clicked;

            playRoundButton = new Button(Content.Load<Texture2D>("gfx/PlayRoundButtons"), new Vector2(_graphics.PreferredBackBufferWidth /2 - 180, _graphics.PreferredBackBufferHeight - 150), swordClashSound);
            playRoundButton.Clicked += PlayRoundButton_Clicked;
        }

        private void PlayRoundButton_Clicked(object sender, System.EventArgs e)
        {
            if (gameController.IsGameRunning)
            {
                gameController.PlayRound(); 
            }
        }
        
        private void NewGameButton_Clicked(object sender, System.EventArgs e)
        {
            StartNewGame();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            CurrentMouseState = Mouse.GetState();
            if (gameController != null && gameController.IsGameRunning)
            {
                playRoundButton.Update(gameTime);
            }
            else
            {
                newGameButton.Update(gameTime);
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Escape)) Exit();
            PreviousMouseState = CurrentMouseState;
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
            _spriteBatch.Begin();
            _spriteBatch.Draw(background,new Rectangle(0,0,_graphics.PreferredBackBufferWidth, _graphics.PreferredBackBufferHeight), Color.White);
            _spriteBatch.DrawStringWithShadow(bigFont, "Adventure Game", new Vector2(GraphicsDevice.Viewport.Bounds.Center.X - 300, 50), Color.White, 5);
            DrawPlayerCharacterInfo(Vector2.One * 200);
            DrawMonsterInfo(new Vector2(1050,200));
            

            if (gameController != null && gameController.IsGameRunning)
            {
                playRoundButton.Draw(_spriteBatch); 
            }
            else
            {
                newGameButton.Draw(_spriteBatch);
            }

            _spriteBatch.End();
        }

        private void DrawMonsterInfo(Vector2 position)
        {
            var spacing = Vector2.UnitY * 65;
            Color textColor = Color.Wheat;
            int shadowOffset = 3;
            if (gameController.Monster != null)
            {
                _spriteBatch.DrawStringWithShadow(font, "Name: " + gameController.Monster.Name, position, textColor, shadowOffset);
                _spriteBatch.DrawStringWithShadow(font, "Class: " + gameController.Monster.MonsterType, position + spacing, textColor, shadowOffset);
                _spriteBatch.DrawStringWithShadow(font, "Weapon: " + gameController.Monster.Weapon, position + spacing * 2, textColor, shadowOffset);
                _spriteBatch.DrawStringWithShadow(font, "HP: " + gameController.Monster.HitPoints, position + spacing * 3, textColor, shadowOffset);
                _spriteBatch.DrawStringWithShadow(font, "Gold: " + gameController.Monster.Gold, position + spacing * 4, textColor, shadowOffset);

            }
        }

        private void DrawPlayerCharacterInfo(Vector2 position)
        {
            var spacing = Vector2.UnitY * 65;
            Color textColor = Color.Wheat;
            int shadowOffset = 3;

            if (gameController.Character != null)
            {
                _spriteBatch.DrawStringWithShadow(font, "Name: " + gameController.Character.Name, position, textColor, shadowOffset);
                _spriteBatch.DrawStringWithShadow(font, "Class: " + gameController.Character.CharacterType, position + spacing, textColor, shadowOffset);
                _spriteBatch.DrawStringWithShadow(font, "Weapon: " + gameController.Character.Weapon, position + spacing * 2, textColor, shadowOffset);
                _spriteBatch.DrawStringWithShadow(font, "HP: " + gameController.Character.HitPoints, position + spacing * 3, textColor, shadowOffset); 
                _spriteBatch.DrawStringWithShadow(font, "Gold: " + gameController.Character.Gold, position + spacing * 4, textColor, shadowOffset);
                _spriteBatch.DrawStringWithShadow(font, "XP: " + gameController.Character.ExperiencePoints, position + spacing * 5, textColor, shadowOffset);

            }
        }

        private void StartNewGame()
        {
            newGameSound.Play();
            gameController.StartNewGame("Joanna", CharacterType.Warrior, new Weapon("Mace", 6));
        }

    }

    public static class ExtensionMethods
    {
        public static void DrawStringWithShadow(this SpriteBatch spritebatch, SpriteFont font,  string text, Vector2 position, Color color, int offsetInPixels = 2)
        {
            spritebatch.DrawString(font, text, position + Vector2.One * offsetInPixels, Color.Black);
            spritebatch.DrawString(font, text, position, color);
        }
    }
}