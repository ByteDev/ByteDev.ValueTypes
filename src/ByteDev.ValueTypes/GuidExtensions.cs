﻿using System;

namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Guid" />.
    /// </summary>
    public static class GuidExtensions
    {
        /// <summary>
        /// Determines if a GUID value is empty (default).
        /// </summary>
        /// <param name="source">The GUID to check.</param>
        /// <returns>True if the GUID is empty (default); otherwise returns false.</returns>
        public static bool IsEmpty(this Guid source)
        {
            return source == Guid.Empty;
        }

        /// <summary>
        /// Makes the GUID value into a a unique sequential GUID.
        /// </summary>
        /// <param name="source">The GUID to make into a unique sequential GUID.</param>
        /// <returns>The new unique sequential GUID.</returns>
        /// <exception cref="T:System.ArgumentException"><paramref name="source" /> is default (empty).</exception>
        public static Guid Comb(this Guid source)
        {
            if(source == default)
                throw new ArgumentException("Value cannot be default (empty).", nameof(source));

            var dateBytes = BitConverter.GetBytes(DateTime.Now.Ticks);
            var guidBytes = source.ToByteArray();

            // Copy last six bytes from the date to the last six bytes of the GUID
            Array.Copy(dateBytes, dateBytes.Length - 7, guidBytes, guidBytes.Length - 7, 6);

            return new Guid(guidBytes);
        }
    }
}
