using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpeezleGame.Graphics
{
    public interface IRenderable
    {
        void Draw(SpriteBatch spriteBatch, Vector2 vector2);

    }
}
