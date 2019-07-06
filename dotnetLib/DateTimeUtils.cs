using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetLib
{
    public static class DateTimeUtils
    {
        #region timestamp func
        /// <summary>
        /// Get current time  timestamp (millisecond).
        /// like System.CurrentTimeMillis() in java.
        /// </summary>
        /// <returns></returns>
        public static long CurrentTimeMillis(this DateTime dateTime)
        {
            var timeSpan = ToUnixMillis(dateTime);
            return (long)timeSpan.TotalMilliseconds;
        }
        /// <summary>
        /// Get current time  timestamp (Seconds).
        /// </summary>
        /// <returns></returns>
        public static long CurrentTimeSeconds(this DateTime dateTime)
        {
            var timeSpan = ToUnixMillis(dateTime);
            return (long)timeSpan.TotalSeconds;
        }

        private static TimeSpan ToUnixMillis(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return diff;
        }

        public static DateTime StampToDateTime(string time)
        {
            time = time.Substring(0, 10);
            double timestamp = Convert.ToInt64(time);
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTime = dateTime.AddSeconds(timestamp).ToLocalTime();
            return dateTime;

        }
        #endregion
    }
}
