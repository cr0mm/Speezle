using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpeezleGame.Graphics
{
    public class RenderingStateMachine
    {
        private readonly List<RenderingState> _states = new List<RenderingState>();
        public RenderingState CurrentState { get; private set; } = null;

        public RenderingStateMachine()
        {

        }

        public void SetState(string name)
        {
            CurrentState = GetState(name);

        }
        public RenderingState AddState(string name, IRenderable renderable)
        {
            var state = new RenderingState(name, renderable);
            _states.Add(state);
            return state;
        }

        public RenderingState GetState(string name) => _states.FirstOrDefault(s => s.Name == name);

        public void RemoveState(RenderingState state)
        {
            _states.Remove(state);

            if(CurrentState == state)
            {
                CurrentState = null;
            }
        }

        public void RemoveState(string stateName)
        {
            var state = GetState(stateName);

            if(state == null)
            {
                return; 
            }
            _states.Remove(state);

            if (CurrentState == state)
            {
                CurrentState = null;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            CurrentState?.Renderable?.Draw(spriteBatch, position);
        }

    }
}
