// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

public partial class MathExTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Max01581()
{
    short w;
    short[] ws = new short[1];
    w = this.Max01(ws);
    Assert.AreEqual<short>((short)0, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Max01235()
{
    short w;
    short[] ws = new short[2];
    ws[0] = (short)84;
    ws[1] = (short)72;
    w = this.Max01(ws);
    Assert.AreEqual<short>((short)84, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Max01380()
{
    short w;
    short[] ws = new short[2];
    ws[0] = (short)86;
    ws[1] = (short)90;
    w = this.Max01(ws);
    Assert.AreEqual<short>((short)90, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Max01ThrowsArgumentNullException455()
{
    short w;
    w = this.Max01((short[])null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Max01ThrowsInvalidOperationException933()
{
    short w;
    short[] ws = new short[0];
    w = this.Max01(ws);
}
}