using System;
using System.Collections.Generic;

using Kiln.KilnEngine.Interfaces;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Kiln.KilnEngine.Systems.ParticleSystem
{
	public class ParticleHandler : ILoadable
	{

		private static List<Particle> particles; 

		void ILoadable.Load()
		{
			particles = new List<Particle>();
		}

		void ILoadable.Unload()
		{
			particles = null;
		}

	}
}
