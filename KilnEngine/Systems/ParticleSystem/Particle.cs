using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Kiln.KilnEngine.Systems.ParticleSystem
{
	public class Particle
	{

		public Rectangle? Frame;
		public Color Color = Color.White;
		public SpriteEffects Effects;
		public Texture2D Texture { get; set; }

		public Vector2 Position;
		public Vector2 Velocity;
		public Vector2 Scale;
		public Vector2 Origin;
		public float Rotation;
		public float Opacity = 1f;
		public float Squish;
		public float Squash;

		public int Height;
		public int Width;

		public bool isAdditive;
		public bool Important;
		public bool DoCustomDraw;

		public virtual void Update()
		{
			Position += Velocity;
		}

		public virtual void Draw(SpriteBatch spriteBatch)
		{
			//spriteBatch.Draw();
		}

		public virtual void CustomDraw() { }

		public virtual void OnSpawn() { }
		public virtual void OnKill() { }

		public virtual void Kill() { }


    }
}
