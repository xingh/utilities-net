﻿using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Extension methods for generic ICollection and classes derived from it.
/// </summary>
public static class CollectionExtensions
{
    /// <summary>
    /// Adds the IEnumerable <paramref name="source"/> elements to this <paramref name="collection"/>.
    /// </summary>
    public static void AddRange<TSource>(this ICollection<TSource> collection, IEnumerable<TSource> source)
    {
        if (collection == null) throw new ArgumentNullException("collection");
        if (source == null) throw new ArgumentNullException("source");

        foreach (var elem in source)
        {
            collection.Add(elem);
        }
    }

    /// <summary>
    /// Adds specified <paramref name="items"/> to this <paramref name="collection"/>.
    /// </summary>
    public static void AddRange<TSource>(this ICollection<TSource> collection, params TSource[] items)
    {
        if (collection == null) throw new ArgumentNullException("collection");
        if (items == null) throw new ArgumentNullException("items");

        foreach (var item in items)
        {
            collection.Add(item);
        }
    }

    /// <summary>
    /// Tests whether the specified <paramref name="index"/> is valid for the <paramref name="list"/>.
    /// </summary>
    public static bool IsValidIndex<TSource>(this IList<TSource> list, int index)
    {
        if (list == null) throw new ArgumentNullException("list");
        return index >= 0 && index < list.Count;
    }

    /// <summary>
    /// Inverts the dictionary (swaps keys and values).
    /// If there are duplicate or null values in source, exception will be thrown.
    /// </summary>
    public static Dictionary<TValue, TKey> Invert<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
    {
        if (source == null) throw new ArgumentNullException("source");

        return source.ToDictionary(i => i.Value, i => i.Key);
    }
}