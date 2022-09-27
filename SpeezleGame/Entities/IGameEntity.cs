using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpeezleGame.Core;

namespace SpeezleGame.Entities
{
    public interface IGameEntity : Core.IUpdatable
    {
        int DrawOrder { get; }

        int UpdateOrder { get; }
        

        void Draw(SpriteBatch spriteBatch, GameTime gameTime);

    }
}
