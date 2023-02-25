using System;
using System.Reflection;

using Microsoft.Xna.Framework.Graphics;

using Kiln.KilnEngine.Interfaces;
using Kiln.KilnEngine.Helpers;

namespace Kiln.KilnEngine.Graphics
{
    public class SpriteBatchCache : ILoadable
    {
        
        public static FieldInfo BlendState { get; set; }
        public static FieldInfo RasterizerState { get; set; }




        void ILoadable.Load()
        {
            BlendState = typeof(SpriteBatch).GetField("sortMode", ReflectionHelper.FlagInstance);
            RasterizerState = typeof(SpriteBatch).GetField("rasterizerState", ReflectionHelper.FlagInstance);
        }
        void ILoadable.Unload() 
        {
            BlendState = null;
            RasterizerState = null;
        }
    }
}
