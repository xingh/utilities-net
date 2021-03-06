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
public void Gcd06ThrowsArgumentNullException912()
{
    ushort w;
    w = this.Gcd06((IEnumerable<ushort>)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Gcd06ThrowsInvalidOperationException532()
{
    ushort w;
    ushort[] ws = new ushort[0];
    w = this.Gcd06((IEnumerable<ushort>)ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Gcd06ThrowsInvalidOperationException482()
{
    ushort w;
    ushort[] ws = new ushort[1];
    w = this.Gcd06((IEnumerable<ushort>)ws);
}
[TestMethod]
[PexGeneratedBy(typeof(global::MathExTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void Gcd06ThrowsInvalidOperationException165()
{
    ushort w;
    ushort[] ws = new ushort[2];
    w = this.Gcd06((IEnumerable<ushort>)ws);
}
}
