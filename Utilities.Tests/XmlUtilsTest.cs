// <copyright file="XmlUtilsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.IO;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for XmlUtils</summary>
[PexClass(typeof(global::XmlUtils))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class XmlUtilsTest
{
    /// <summary>Test stub for CheckValid(String)</summary>
    [PexMethod(MaxRunsWithoutNewTests = 200, MaxConstraintSolverTime = 10)]
    public bool CheckValid(string xml)
    {
        PexAssume.IsTrue(xml.Length < 50);
        bool result = global::XmlUtils.CheckValid(xml);
        return result;
        // TODO: add assertions to method XmlUtilsTest.CheckValid(String)
    }

    /// <summary>Test stub for CheckValid(Stream)</summary>
    [PexMethod]
    public bool CheckValid01(Stream stream)
    {
        bool result = global::XmlUtils.CheckValid(stream);
        return result;
        // TODO: add assertions to method XmlUtilsTest.CheckValid01(Stream)
    }

    /// <summary>Test stub for CheckValid(TextReader)</summary>
    [PexMethod]
    public bool CheckValid02(TextReader reader)
    {
        bool result = global::XmlUtils.CheckValid(reader);
        return result;
        // TODO: add assertions to method XmlUtilsTest.CheckValid02(TextReader)
    }

    /// <summary>Test stub for CheckValidFile(String)</summary>
    [PexMethod]
    public bool CheckValidFile(string filename)
    {
        bool result = global::XmlUtils.CheckValidFile(filename);
        return result;
        // TODO: add assertions to method XmlUtilsTest.CheckValidFile(String)
    }
}
