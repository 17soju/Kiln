using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Kiln.KilnEngine
{
    /// <summary>
    /// Multipurpose FNA based 2D framework. 
    /// </summary>
    public abstract class KilnEngine : Game
    {

        public static KilnEngine Instance;

        public KilnEngine() : base()
        {
            Instance = this;
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }


    }
}
