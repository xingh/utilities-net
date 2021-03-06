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

public partial class StringUtilsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ToSentenceCaseThrowsArgumentNullException815()
{
    string s;
    s = this.ToSentenceCase((string)null);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void ToSentenceCase578()
{
    string s;
    s = this.ToSentenceCase("");
    Assert.AreEqual<string>("", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void ToSentenceCase913()
{
    string s;
    s = this.ToSentenceCase("a");
    Assert.AreEqual<string>("A", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
[Ignore]
[PexDescription("the test state was: duplicate path")]
public void ToSentenceCase91301()
{
    string s;
    s = this.ToSentenceCase("a");
    Assert.AreEqual<string>("A", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void ToSentenceCase201()
{
    string s;
    s = this.ToSentenceCase("aa");
    Assert.AreEqual<string>("Aa", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void ToSentenceCase308()
{
    string s;
    s = this.ToSentenceCase("aA");
    Assert.AreEqual<string>("A a", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void ToSentenceCase855()
{
    string s;
    s = this.ToSentenceCase("aAa");
    Assert.AreEqual<string>("A aa", s);
}
[TestMethod]
[PexGeneratedBy(typeof(global::StringUtilsTest))]
public void ToSentenceCase485()
{
    string s;
    s = this.ToSentenceCase("aaaaaAaAaaaa");
    Assert.AreEqual<string>("Aaaaa aa aaaaa", s);
}
}
