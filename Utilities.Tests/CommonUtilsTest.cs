// <copyright file="CommonUtilsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Collections;
using System.Linq;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for CommonUtils</summary>
[PexClass(typeof(global::CommonUtils))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class CommonUtilsTest
{
    /// <summary>Test for IsOneOf(!!0, !!0[])</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsOneOf<T>(T obj, T[] values)
    {
        bool result = global::CommonUtils.IsOneOf<T>(obj, values);

        PexAssert.AreEqual(values.Contains(obj), result);

        return result;
    }

    /// <summary>Test for NullSafe(Func`1&lt;!!0&gt;, !!0)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod, PexAllowedException(typeof(OperationCanceledException))] // it's the exception which can be thrown by created Func
    public T NullSafe<T>(global::System.Func<T> function, T defaultValue)
    {
        T result = global::CommonUtils.NullSafe<T>(function, defaultValue);

        try
        {
            T expected = function();
            PexAssert.AreEqual(expected, result);
        }
        catch (NullReferenceException)
        {
            PexAssert.AreEqual(defaultValue, result);
        }
        catch
        {
            PexAssert.Fail();
        }

        return result;
    }

    /// <summary>Test for Safe(Func`1&lt;!!0&gt;, !!0)</summary>
    [global::Microsoft.Pex.Framework.PexGenericArguments(typeof(int))]
    [global::Microsoft.Pex.Framework.PexMethod]
    public T Safe<T>(global::System.Func<T> function, T defaultValue)
    {
        T result = global::CommonUtils.Safe<T>(function, defaultValue);

        try
        {
            T expected = function();
            PexAssert.AreEqual(expected, result);
        }
        catch
        {
            PexAssert.AreEqual(defaultValue, result);
        }

        return result;
    }
}
