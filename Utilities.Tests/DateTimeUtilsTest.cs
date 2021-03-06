// <copyright file="DateTimeUtilsTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/// <summary>This class contains parameterized unit tests for DateTimeUtils</summary>
[PexClass(typeof(global::DateTimeUtils))]
[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
[TestClass]
public partial class DateTimeUtilsTest
{
    /// <summary>Test stub for CalculateAge(DateTime, DateTime)</summary>
    [PexMethod]
    public int CalculateAge01(DateTime birthDate, DateTime referenceDate)
    {
        int result = global::DateTimeUtils.CalculateAge(birthDate, referenceDate);
        return result;
        // TODO: add assertions to method DateTimeUtilsTest.CalculateAge01(DateTime, DateTime)
    }

    /// <summary>Test stub for DaysInMonth(DateTime)</summary>
    [PexMethod]
    public int DaysInMonth(DateTime date)
    {
        int result = global::DateTimeUtils.DaysInMonth(date);
        return result;
        // TODO: add assertions to method DateTimeUtilsTest.DaysInMonth(DateTime)
    }

    /// <summary>Test for FromUnixTime(Int64, Boolean)</summary>
    [PexMethod, PexAllowedException(typeof(OverflowException))]
    public DateTime FromUnixTime(long unixTime, bool withMilliseconds)
    {
        DateTime result = global::DateTimeUtils.FromUnixTime(unixTime, withMilliseconds);

        // force Pex to explore special cases
        if (Math.Abs(unixTime) > 1000000000 && Math.Abs(unixTime) < 10000000000) { }

        PexAssert.AreEqual(result.ToUnixTime(withMilliseconds), unixTime);

        return result;
    }

    /// <summary>Test for ToUnixTime(DateTime, Boolean)</summary>
    [PexMethod]
    public long ToUnixTime(DateTime dateTime, bool withMilliseconds)
    {
        long result = global::DateTimeUtils.ToUnixTime(dateTime, withMilliseconds);

        // force Pex to explore special cases
        if (Math.Abs(result) > 1000000000 && Math.Abs(result) < 10000000000) { }

        dateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second, withMilliseconds ? dateTime.Millisecond : 0);
        PexAssert.AreEqual(DateTimeUtils.FromUnixTime(result, withMilliseconds), dateTime);

        return result;
    }
}