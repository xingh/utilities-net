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

public partial class GenericEnumerableExtensionsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void MinItem01ThrowsArgumentNullException1()
{
    int i;
    i = this.MinItem01<int, int>((IEnumerable<int>)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void MinItem01ThrowsInvalidOperationException60()
{
    int i;
    int[] ints = new int[0];
    i = this.MinItem01<int, int>((IEnumerable<int>)ints);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void MinItem01348()
{
    int i;
    int[] ints = new int[1];
    i = this.MinItem01<int, int>((IEnumerable<int>)ints);
    Assert.AreEqual<int>(0, i);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void MinItem01446()
{
    int i;
    int[] ints = new int[2];
    i = this.MinItem01<int, int>((IEnumerable<int>)ints);
    Assert.AreEqual<int>(0, i);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void MinItemThrowsArgumentNullException18()
{
    int i;
    i = this.MinItem<int, int>((IEnumerable<int>)null, (Func<int, int>)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void MinItemThrowsArgumentNullException852()
{
    int i;
    int[] ints = new int[0];
    i = this.MinItem<int, int>((IEnumerable<int>)ints, (Func<int, int>)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void MinItemThrowsInvalidOperationException76()
{
    object o;
    int i;
    o = FuncFactory.Create();
    int[] ints = new int[0];
    i = this.MinItem<int, int>((IEnumerable<int>)ints, (Func<int, int>)o);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void MinItem937()
{
    object o;
    int i;
    o = FuncFactory.Create();
    int[] ints = new int[1];
    i = this.MinItem<int, int>((IEnumerable<int>)ints, (Func<int, int>)o);
    Assert.AreEqual<int>(0, i);
}
[TestMethod]
[PexGeneratedBy(typeof(global::GenericEnumerableExtensionsTest))]
public void MinItem364()
{
    object o;
    int i;
    o = FuncFactory.Create();
    int[] ints = new int[2];
    i = this.MinItem<int, int>((IEnumerable<int>)ints, (Func<int, int>)o);
    Assert.AreEqual<int>(0, i);
}
}