using System;
using Microsoft.Pex.Framework;

namespace System
{
    /// <summary>A factory for System.Func`1[System.Int32] instances</summary>
    public static partial class FuncFactory
    {
        /// <summary>A factory for System.Func[int] instances</summary>
        [PexFactoryMethod(typeof(Func<int>))]
        public static object Create(bool throwEx, bool isNullEx, int value)
        {
            return new Func<int>(() =>
                {
                    if (throwEx)
                    {
                        if (isNullEx) throw new NullReferenceException();
                        else throw new OperationCanceledException(); // just another type of exception
                    }
                    else
                    {
                        return value;
                    }
                });
        }

        /// <summary>A factory for System.Func`2[System.Int32,System.Int32] instances</summary>
        [PexFactoryMethod(typeof(Func<int, int>))]
        public static object Create()
        {
            return new Func<int, int>(i => i + 1);
        }

        /// <summary>A factory for System.Func`2[System.Int32,System.Int32] instances</summary>
        [PexFactoryMethod(typeof(Func<int, string>))]
        public static object Create(int a)
        {
            return new Func<int, string>(i => i.ToString() + a.ToString());
        }

        /// <summary>A factory for System.Func`3[System.Int32,System.Int32,System.Boolean] instances</summary>
        [PexFactoryMethod(typeof(Func<int, int, bool>))]
        public static object Create(int to, bool value)
        {
            return new Func<int, int, bool>((i, j) => j < to ? value : !value);
        }

        /// <summary>A factory for System.Func`2[System.Int32,System.Boolean] instances</summary>
        [PexFactoryMethod(typeof(Func<int, bool>))]
        public static object Create(bool value)
        {
            return new Func<int, bool>(i => value);
        }
    }
}
