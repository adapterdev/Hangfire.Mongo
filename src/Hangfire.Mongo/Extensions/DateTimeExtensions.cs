using System;

namespace Hangfire.Mongo.Extensions
{
#pragma warning disable 1591
    public static class DateTimeExtensions
    {
        public static int DateToInt(this DateTime dateTime) => Int32.Parse(dateTime.ToString("yyyyMMdd"));

        public static double DateTimeToInt(this DateTime dateTime) => Double.Parse(dateTime.ToString("yyyyMMddHHmmss"));
    }
#pragma warning restore 1591
}