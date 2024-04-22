using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame3___Animation
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D brownTribbleTexture;
        Texture2D creamTribbleTexture;
        Texture2D greyTribbleTexture;
        Texture2D orangeTribbleTexture;

        Rectangle brownTribbleRect;
        Rectangle creamTribbleRect;
        Rectangle greyTribbleRect;
        Rectangle orangeTribbleRect;
        Rectangle window;

        Vector2 brownTribbleSpeed;
        Vector2 creamTribbleSpeed;
        Vector2 greyTribbleSpeed;
        Vector2 orangeTribbleSpeed;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;

            brownTribbleRect = new Rectangle(100, 300, 100, 100);
            brownTribbleSpeed = new Vector2(8, 2);

            creamTribbleRect = new Rectangle(300, 300, 100, 100);
            creamTribbleSpeed = new Vector2(10, 0);

            greyTribbleRect = new Rectangle(500, 10, 100, 100);
            greyTribbleSpeed = new Vector2(10, 0);

            orangeTribbleRect = new Rectangle(200, 100, 100, 100);
            orangeTribbleSpeed = new Vector2(10, 0);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            brownTribbleTexture = Content.Load<Texture2D>("tribbleBrown");
            creamTribbleTexture = Content.Load<Texture2D>("tribbleCream");
            greyTribbleTexture = Content.Load<Texture2D>("tribbleGrey");
            orangeTribbleTexture = Content.Load<Texture2D>("tribbleOrange");
            

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            // Left n Right
            brownTribbleRect.X += (int)brownTribbleSpeed.X;
            if (brownTribbleRect.Right > window.Width || brownTribbleRect.Left < 0)
            {
                brownTribbleSpeed.X *= -1;
            }

            // Up n Down
            brownTribbleRect.Y += (int)brownTribbleSpeed.Y;
            if (brownTribbleRect.Top < 0 || brownTribbleRect.Bottom > window.Height)
            {
                brownTribbleSpeed.Y *= -1;
            }

            /* creamTribbleRect.X += (int)creamTribbleSpeed.X;
            creamTribbleRect.Y += (int)creamTribbleSpeed.Y; */


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(brownTribbleTexture, brownTribbleRect, Color.White);
            _spriteBatch.Draw(creamTribbleTexture, creamTribbleRect, Color.White);
            _spriteBatch.Draw(greyTribbleTexture, greyTribbleRect, Color.White);
            _spriteBatch.Draw(orangeTribbleTexture, orangeTribbleRect, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}