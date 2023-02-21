using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Kiln.KilnEngine.Drawing
{
    public abstract class AdditiveDrawing
    {
        /// <summary>
        /// todo
        /// </summary>
        /// <param name="spriteBatch"></param>
        public static void DrawAdditive(SpriteBatch spriteBatch)
        {

            spriteBatch.Begin(default, BlendState.Additive, SamplerState.PointWrap, default, default, default);

            spriteBatch.End();


        }
    }
}
