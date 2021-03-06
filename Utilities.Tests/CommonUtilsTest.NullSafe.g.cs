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

public partial class CommonUtilsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::CommonUtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void NullSafeThrowsArgumentNullException15()
{
    int i;
    i = this.NullSafe<int>((Func<int>)null, 0);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CommonUtilsTest))]
public void NullSafe46202()
{
    object o;
    int i;
    o = FuncFactory.Create(false, false, 0);
    i = this.NullSafe<int>((Func<int>)o, 0);
    Assert.AreEqual<int>(0, i);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CommonUtilsTest))]
[ExpectedException(typeof(OperationCanceledException))]
public void NullSafeThrowsOperationCanceledException663()
{
    object o;
    int i;
    o = FuncFactory.Create(true, false, 0);
    i = this.NullSafe<int>((Func<int>)o, 0);
}
[TestMethod]
[PexGeneratedBy(typeof(global::CommonUtilsTest))]
public void NullSafe46203()
{
    object o;
    int i;
    o = FuncFactory.Create(true, true, 0);
    i = this.NullSafe<int>((Func<int>)o, 0);
    Assert.AreEqual<int>(0, i);
}
}
