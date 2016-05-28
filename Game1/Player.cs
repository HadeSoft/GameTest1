using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Player
    {
        public Texture2D PlayerTexture;

        public Vector2 Position;

        public void Initialize(Texture2D texture, Vector2 position)
        {
            PlayerTexture = texture;
            Position = position;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch sB)
        {
            sB.Draw(PlayerTexture, Position, null, Color.Blue, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }

        public int Width
        {
            get { return PlayerTexture.Width; }
        }

        public int Height
        {
            get { return PlayerTexture.Height; }
        }
    }
}
