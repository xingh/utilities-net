using System;
using Microsoft.Pex.Framework;

namespace System
{
    /// <summary>A factory for System.Action`1[System.Int32] instances</summary>
    public static partial class ActionFactory
    {
        /// <summary>A factory for System.Action`1[System.Int32] instances</summary>
        [PexFactoryMethod(typeof(Action<int>))]
        public static object Create()
        {
            return new Action<int>(i => { });
        }
    }
}
