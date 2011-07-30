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
using Microsoft.Pex.Framework.Exceptions;

public partial class MathExTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Lcm01833()
{
    short w;
    w = this.Lcm01((short)32, (short)32);
    Assert.AreEqual<short>((short)32, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(OverflowException))]
public void Lcm01ThrowsOverflowException808()
{
    short w;
    w = this.Lcm01((short)short.MinValue, (short)32);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Lcm0184()
{
    short w;
    w = this.Lcm01((short)(-1), (short)32);
    Assert.AreEqual<short>((short)32, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(OverflowException))]
public void Lcm01ThrowsOverflowException762()
{
    short w;
    w = this.Lcm01((short)(-1), (short)short.MinValue);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Lcm01ThrowsInvalidOperationException241()
{
    short w;
    w = this.Lcm01((short)0, (short)32);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Lcm01886()
{
    short w;
    w = this.Lcm01((short)32, (short)(-1));
    Assert.AreEqual<short>((short)32, w);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
public void Lcm01587()
{
    short w;
    w = this.Lcm01((short)(-1), (short)(-1));
    Assert.AreEqual<short>((short)1, w);
}
}