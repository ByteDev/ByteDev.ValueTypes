using System;
using System.Globalization;

namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Guid" />.
    /// </summary>
    public static class GuidExtensions
    {
        /// <summary>
        /// Determines if a Guid value is empty (default).
        /// </summary>
        /// <param name="source">The Guid to check.</param>
        /// <returns>True if the Guid is empty (default); otherwise returns false.</returns>
        public static bool IsEmpty(this Guid source)
        {
            return source == Guid.Empty;
        }

        /// <summary>
        /// Makes the Guid value into a a unique sequential Guid.
        /// </summary>
        /// <param name="source">The Guid to make into a unique sequential Guid.</param>
        /// <returns>The new unique sequential Guid.</returns>
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

        /// <summary>
        /// Returns the Guid as a string. This method provides greater control over the string representation of the
        /// Guid rather than using a string format. Beware that string representations with surrounding brackets and no 
        /// delimiters are often not parsable using the Guid.Parse method.
        /// </summary>
        /// <param name="source">The Guid to perform the operation on.</param>
        /// <param name="flags">Flags to control the string representation of the Guid</param>
        /// <returns>String representation of the Guid.</returns>
        public static string ToString(this Guid source, GuidStringFlags flags)
        {
            var str = source.ToString("D");     // .NET default format "D" = "00000000-0000-0000-0000-000000000000"

            if (flags.HasFlag(GuidStringFlags.NoDelimiters))
                str = str.Replace("-", string.Empty);

            if (flags.HasFlag(GuidStringFlags.UpperCase))
                str = str.ToUpper(CultureInfo.InvariantCulture);

            if (flags.HasFlag(GuidStringFlags.Brackets))
                str = "{" + str + "}";

            return str;
        }
    }
}
