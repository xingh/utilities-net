// <copyright file="CollectionExtensionsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for CollectionExtensions</summary>
[PexClass(typeof(global::CollectionExtensions))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class CollectionExtensionsTest
{
    /// <summary>Test for AddRange(ICollection`1&lt;!!0&gt;, IEnumerable`1&lt;!!0&gt;)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod, PexAllowedException(typeof(NotSupportedException))]
    public ICollection<TSource> AddRange<TSource>(ICollection<TSource> collection, IEnumerable<TSource> source)
    {
        var coll = collection != null ? collection.ToList() : null;

        global::CollectionExtensions.AddRange<TSource>(collection, source);

        PexAssert.AreEqual(coll.Count + source.Count(), collection.Count);
        PexAssert.AreElementsEqual(collection, coll.Concat(source), (l, r) => l.Equals(r));

        return collection;
    }

    /// <summary>Test for AddRange(ICollection`1&lt;!!0&gt;, !!0[])</summary>
    [PexMethod, PexAllowedException(typeof(NotSupportedException))]
    public ICollection<int> AddRange01(ICollection<int> collection, int[] items)
    {
        var coll = collection != null ? collection.ToList() : null;

        global::CollectionExtensions.AddRange(collection, items);

        PexAssert.AreEqual(coll.Count + items.Length, collection.Count);
        PexAssert.AreElementsEqual(collection, coll.Concat(items), (l, r) => l.Equals(r));

        return collection;
    }

    /// <summary>Test for both AddRanges</summary>
    [PexMethod]
    public void AddRanges(int[] sources, int n1, int n2)
    {
        PexAssume.IsNotNullOrEmpty(sources);
        PexAssume.AreDistinctValues(sources);
        PexAssume.InRange(n1, 0, 10);
        PexAssume.InRange(n2, 0, 10);
        PexAssume.AreEqual(n1 + n2, sources.Length);

        var coll1 = sources.Take(n1).ToList();
        var coll2 = sources.Take(n1).ToList();
        var en = sources.Skip(n1);

        AddRange(coll1, en);
        AddRange01(coll2, en.ToArray());

        PexAssert.AreElementsEqual(sources, coll1.ToArray());
        PexAssert.AreElementsEqual(sources, coll2.ToArray());
    }

    /// <summary>Test for Invert(IEnumerable`1&lt;KeyValuePair`2&lt;!!0,!!1&gt;&gt;)</summary>
    [PexGenericArguments(typeof(int), typeof(int))]
    [PexMethod, PexAllowedException(typeof(ArgumentException))]
    public Dictionary<TValue, TKey> Invert<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> source)
    {
        bool? duplicates = source != null ? (bool?)(source.Select(kvp => kvp.Value).Distinct().Count() != source.Count()) : null;
        PexObserve.Value("duplicates", duplicates);

        Dictionary<TValue, TKey> result = global::CollectionExtensions.Invert<TKey, TValue>(source);

        PexAssert.IsFalse(duplicates.Value);
        PexAssert.AreEqual(source.Count(), result.Count);
        foreach (var el in source)
        {
            PexAssert.AreEqual(el.Key, result[el.Value]);
        }

        return result;
    }

    /// <summary>Test stub for IsValidIndex(IList`1&lt;!!0&gt;, Int32)</summary>
    [PexGenericArguments(typeof(int))]
    [PexMethod]
    public bool IsValidIndex<TSource>(IList<TSource> list, int index)
    {
        bool result = global::CollectionExtensions.IsValidIndex<TSource>(list, index);

        if (result && index > 0) { }

        try
        {
            var v = list[index];
            PexAssert.IsTrue(result);
        }
        catch
        {
            PexAssert.IsFalse(result);
        }

        return result;
    }
}
