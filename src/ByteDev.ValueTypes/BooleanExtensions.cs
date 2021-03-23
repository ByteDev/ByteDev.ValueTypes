﻿using System;

namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Boolean" />.
    /// </summary>
    public static class BooleanExtensions
    {
        /// <summary>
        /// Returns a string representation of the boolean value in a given format.
        /// </summary>
        /// <param name="source">Boolean to perform the operation on.</param>
        /// <param name="format">Format of the returned string.</param>
        /// <returns>String in the provided format.</returns>
        public static string ToString(this bool source, BoolStringFormat format = BoolStringFormat.TitleCase)
        {
            switch (format)
            {
                case BoolStringFormat.TitleCase:
                    return source.ToString();

                case BoolStringFormat.LowerCase:
                    return source.ToString().ToLowerInvariant();

                case BoolStringFormat.UpperCase:
                    return source.ToString().ToUpperInvariant();

                case BoolStringFormat.Binary:
                    return source ? "1" : "0";

                case BoolStringFormat.YesNo:
                    return source ? "Yes" : "No";

                case BoolStringFormat.OnOff:
                    return source ? "On" : "Off";

                default:
                    throw new InvalidOperationException($"Unexpected value '{format}' for enum '{typeof(BoolStringFormat).FullName}'.");
            }
        }
    }
}