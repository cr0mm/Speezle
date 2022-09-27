using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpeezleGame.Graphics
{
    public class RenderingState
    {
        public string Name { get; private set; }
        public IRenderable Renderable { get; }

        public RenderingState(string name, IRenderable renderable)
        {
            Name = name;
            Renderable = renderable;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            Renderable?.Draw(spriteBatch, position);
        }
    }
}
