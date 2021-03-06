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
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public partial class CollectionExtensionsTest
{
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void InvertThrowsArgumentNullException264()
{
    Dictionary<int, int> dictionary;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      dictionary = this.Invert<int, int>((IEnumerable<KeyValuePair<int, int>>)null);
      bool? ovduplicates = observer.GetObservedValue<bool?>("duplicates");
      Assert.IsNull((object)ovduplicates);
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
public void Invert404()
{
    Dictionary<int, int> dictionary;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[0];
      dictionary =
        this.Invert<int, int>((IEnumerable<KeyValuePair<int, int>>)keyValuePairs);
      Assert.IsNotNull((object)dictionary);
      Assert.IsNotNull(dictionary.Comparer);
      Assert.AreEqual<int>(0, dictionary.Count);
      bool? ovduplicates = observer.GetObservedValue<bool?>("duplicates");
      Assert.IsNotNull((object)ovduplicates);
      Assert.AreEqual<bool>(false, (bool)((object)ovduplicates));
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
public void Invert889()
{
    Dictionary<int, int> dictionary;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[1];
      dictionary =
        this.Invert<int, int>((IEnumerable<KeyValuePair<int, int>>)keyValuePairs);
      Assert.IsNotNull((object)dictionary);
      Assert.IsNotNull(dictionary.Comparer);
      Assert.AreEqual<int>(1, dictionary.Count);
      bool? ovduplicates = observer.GetObservedValue<bool?>("duplicates");
      Assert.IsNotNull((object)ovduplicates);
      Assert.AreEqual<bool>(false, (bool)((object)ovduplicates));
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
public void Invert786()
{
    Dictionary<int, int> dictionary;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[2];
      KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 1);
      keyValuePairs[0] = s0;
      KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(default(int), 28);
      keyValuePairs[1] = s1;
      dictionary =
        this.Invert<int, int>((IEnumerable<KeyValuePair<int, int>>)keyValuePairs);
      Assert.IsNotNull((object)dictionary);
      Assert.IsNotNull(dictionary.Comparer);
      Assert.AreEqual<int>(2, dictionary.Count);
      bool? ovduplicates = observer.GetObservedValue<bool?>("duplicates");
      Assert.IsNotNull((object)ovduplicates);
      Assert.AreEqual<bool>(false, (bool)((object)ovduplicates));
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
public void Invert781()
{
    Dictionary<int, int> dictionary;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[7];
      KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 4);
      keyValuePairs[0] = s0;
      KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(default(int), 1013);
      keyValuePairs[1] = s1;
      KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(default(int), 769);
      keyValuePairs[2] = s2;
      KeyValuePair<int, int> s3 = new KeyValuePair<int, int>(default(int), 449);
      keyValuePairs[3] = s3;
      KeyValuePair<int, int> s4 = new KeyValuePair<int, int>(default(int), 268);
      keyValuePairs[4] = s4;
      KeyValuePair<int, int> s5 = new KeyValuePair<int, int>(default(int), 259);
      keyValuePairs[5] = s5;
      KeyValuePair<int, int> s6 = new KeyValuePair<int, int>(default(int), 262);
      keyValuePairs[6] = s6;
      dictionary =
        this.Invert<int, int>((IEnumerable<KeyValuePair<int, int>>)keyValuePairs);
      Assert.IsNotNull((object)dictionary);
      Assert.IsNotNull(dictionary.Comparer);
      Assert.AreEqual<int>(7, dictionary.Count);
      bool? ovduplicates = observer.GetObservedValue<bool?>("duplicates");
      Assert.IsNotNull((object)ovduplicates);
      Assert.AreEqual<bool>(false, (bool)((object)ovduplicates));
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
public void Invert262()
{
    Dictionary<int, int> dictionary;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[7];
      KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 872);
      keyValuePairs[0] = s0;
      KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(default(int), 12);
      keyValuePairs[1] = s1;
      KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(default(int), 1000);
      keyValuePairs[2] = s2;
      KeyValuePair<int, int> s3 = new KeyValuePair<int, int>(default(int), 45);
      keyValuePairs[3] = s3;
      KeyValuePair<int, int> s4 = new KeyValuePair<int, int>(default(int), 911);
      keyValuePairs[4] = s4;
      KeyValuePair<int, int> s5 = new KeyValuePair<int, int>(default(int), 512);
      keyValuePairs[6] = s5;
      dictionary =
        this.Invert<int, int>((IEnumerable<KeyValuePair<int, int>>)keyValuePairs);
      Assert.IsNotNull((object)dictionary);
      Assert.IsNotNull(dictionary.Comparer);
      Assert.AreEqual<int>(7, dictionary.Count);
      bool? ovduplicates = observer.GetObservedValue<bool?>("duplicates");
      Assert.IsNotNull((object)ovduplicates);
      Assert.AreEqual<bool>(false, (bool)((object)ovduplicates));
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentException))]
public void InvertThrowsArgumentException544()
{
    Dictionary<int, int> dictionary;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[11];
      KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 872);
      keyValuePairs[0] = s0;
      KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(default(int), 12);
      keyValuePairs[1] = s1;
      KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(default(int), 1000);
      keyValuePairs[2] = s2;
      KeyValuePair<int, int> s3 = new KeyValuePair<int, int>(default(int), 45);
      keyValuePairs[3] = s3;
      KeyValuePair<int, int> s4 = new KeyValuePair<int, int>(default(int), 911);
      keyValuePairs[4] = s4;
      KeyValuePair<int, int> s5 = new KeyValuePair<int, int>(default(int), 512);
      keyValuePairs[6] = s5;
      dictionary =
        this.Invert<int, int>((IEnumerable<KeyValuePair<int, int>>)keyValuePairs);
      bool? ovduplicates = observer.GetObservedValue<bool?>("duplicates");
      Assert.IsNotNull((object)ovduplicates);
      Assert.AreEqual<bool>(true, (bool)((object)ovduplicates));
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentException))]
public void InvertThrowsArgumentException930()
{
    Dictionary<int, int> dictionary;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[11];
      KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 4);
      keyValuePairs[0] = s0;
      KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(default(int), 1013);
      keyValuePairs[1] = s1;
      KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(default(int), 769);
      keyValuePairs[2] = s2;
      KeyValuePair<int, int> s3 = new KeyValuePair<int, int>(default(int), 449);
      keyValuePairs[3] = s3;
      KeyValuePair<int, int> s4 = new KeyValuePair<int, int>(default(int), 268);
      keyValuePairs[4] = s4;
      KeyValuePair<int, int> s5 = new KeyValuePair<int, int>(default(int), 259);
      keyValuePairs[5] = s5;
      KeyValuePair<int, int> s6 = new KeyValuePair<int, int>(default(int), 262);
      keyValuePairs[6] = s6;
      dictionary =
        this.Invert<int, int>((IEnumerable<KeyValuePair<int, int>>)keyValuePairs);
      bool? ovduplicates = observer.GetObservedValue<bool?>("duplicates");
      Assert.IsNotNull((object)ovduplicates);
      Assert.AreEqual<bool>(true, (bool)((object)ovduplicates));
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
public void Invert210()
{
    Dictionary<int, int> dictionary;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[8];
      KeyValuePair<int, int> s0 = new KeyValuePair<int, int>(default(int), 4);
      keyValuePairs[0] = s0;
      KeyValuePair<int, int> s1 = new KeyValuePair<int, int>(default(int), 453);
      keyValuePairs[1] = s1;
      KeyValuePair<int, int> s2 = new KeyValuePair<int, int>(default(int), 41);
      keyValuePairs[2] = s2;
      KeyValuePair<int, int> s3 = new KeyValuePair<int, int>(default(int), 3);
      keyValuePairs[3] = s3;
      KeyValuePair<int, int> s4 = new KeyValuePair<int, int>(default(int), 16);
      keyValuePairs[5] = s4;
      KeyValuePair<int, int> s5 = new KeyValuePair<int, int>(default(int), 224);
      keyValuePairs[6] = s5;
      KeyValuePair<int, int> s6 = new KeyValuePair<int, int>(default(int), 5);
      keyValuePairs[7] = s6;
      dictionary =
        this.Invert<int, int>((IEnumerable<KeyValuePair<int, int>>)keyValuePairs);
      Assert.IsNotNull((object)dictionary);
      Assert.IsNotNull(dictionary.Comparer);
      Assert.AreEqual<int>(8, dictionary.Count);
      bool? ovduplicates = observer.GetObservedValue<bool?>("duplicates");
      Assert.IsNotNull((object)ovduplicates);
      Assert.AreEqual<bool>(false, (bool)((object)ovduplicates));
    }
}
[TestMethod]
[PexGeneratedBy(typeof(global::CollectionExtensionsTest))]
[ExpectedException(typeof(ArgumentException))]
public void InvertThrowsArgumentException512()
{
    Dictionary<int, int> dictionary;
    using (IPexObserveContext observer = PexObserve.NewTest())
    {
      KeyValuePair<int, int>[] keyValuePairs = new KeyValuePair<int, int>[4];
      KeyValuePair<int, int> s0
         = new KeyValuePair<int, int>(default(int), int.MinValue);
      keyValuePairs[1] = s0;
      dictionary =
        this.Invert<int, int>((IEnumerable<KeyValuePair<int, int>>)keyValuePairs);
      bool? ovduplicates = observer.GetObservedValue<bool?>("duplicates");
      Assert.IsNotNull((object)ovduplicates);
      Assert.AreEqual<bool>(true, (bool)((object)ovduplicates));
    }
}
}
