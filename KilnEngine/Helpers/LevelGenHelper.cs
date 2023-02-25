using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

using Kiln.KilnEngine.Helpers.Noise;
using Kiln.KilnEngine;

namespace Kiln.KilnEngine.Helpers
{
    public abstract class LevelGenHelper
    {

        FastNoise fastNoise = new FastNoise(KilnEngine.rand.Next());

        public class LevelArea
        {
            Point topLeft;
            Point topRight;
            Point bottomLeft;
            Point bottomRight;

            public LevelArea()
            {
                topLeft = new Point();
                topRight = new Point();
                bottomLeft = new Point();
                bottomRight = new Point();
            }
        }









    }
}
