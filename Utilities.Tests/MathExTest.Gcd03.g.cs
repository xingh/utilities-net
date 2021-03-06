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
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

public partial class MathExTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void Gcd03ThrowsArgumentNullException252()
{
    short w;
    w = this.Gcd03((IEnumerable<short>)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Gcd03ThrowsInvalidOperationException191()
{
    short w;
    short[] ws = new short[0];
    w = this.Gcd03((IEnumerable<short>)ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Gcd03ThrowsInvalidOperationException116()
{
    short w;
    short[] ws = new short[1];
    w = this.Gcd03((IEnumerable<short>)ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Gcd03ThrowsInvalidOperationException595()
{
    short w;
    short[] ws = new short[2];
    w = this.Gcd03((IEnumerable<short>)ws);
}
}
