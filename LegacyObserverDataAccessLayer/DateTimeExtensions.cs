// -----------------------------------------------------------------------
// <copyright file="DateTimeExtensions.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Spc.Ofp.Legacy.Observer.ExtensionMethods
{
    using System;

    /// <summary>
    /// Extension methods for working with the DateTime struct
    /// </summary>
    public static class DateTimeExtensions
    {
        public static DateTime? Combine(this DateTime? dateOnly, string timeOnly)
        {
            if (!dateOnly.HasValue)
            {
                return null;
            }
            DateTime fullDate = new DateTime(dateOnly.Value.Ticks);

            if (null != timeOnly)
            {
                if (5 == timeOnly.Trim().Length && timeOnly.Contains(":"))
                    timeOnly = timeOnly.Replace(":", String.Empty);
                if (4 == timeOnly.Trim().Length)
                {               
                    double hours = 0;                
                    if (Double.TryParse(timeOnly.Substring(0, 2), out hours))
                    {
                        System.Diagnostics.Debug.WriteLine("hours: " + hours);
                        fullDate = fullDate.AddHours(hours);
                    }
                    double minutes = 0;
                    if (Double.TryParse(timeOnly.Substring(2, 2), out minutes))
                    {
                        fullDate = fullDate.AddMinutes(minutes);
                    }
                }
            }
            return fullDate;
        }
    }
}
