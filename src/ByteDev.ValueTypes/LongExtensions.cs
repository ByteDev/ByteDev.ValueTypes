namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Int64" />.
    /// </summary>
    public static class LongExtensions
    {
        /// <summary>
        /// Returns the number of digits in a long.
        /// </summary>
        /// <param name="source">Long to perform the operation on.</param>
        /// <param name="minusIsDigit">Whether to treat any minus sign as a digit.</param>
        /// <returns>Number of digits in the long.</returns>
        public static int GetDigits(this long source, bool minusIsDigit = true)
        {
            if (source >= 0)
            {
                if (source < 10L) return 1;
                if (source < 100L) return 2;
                if (source < 1000L) return 3;
                if (source < 10000L) return 4;
                if (source < 100000L) return 5;
                if (source < 1000000L) return 6;
                if (source < 10000000L) return 7;
                if (source < 100000000L) return 8;
                if (source < 1000000000L) return 9;
                if (source < 10000000000L) return 10;
                if (source < 100000000000L) return 11;
                if (source < 1000000000000L) return 12;
                if (source < 10000000000000L) return 13;
                if (source < 100000000000000L) return 14;
                if (source < 1000000000000000L) return 15;
                if (source < 10000000000000000L) return 16;
                if (source < 100000000000000000L) return 17;
                if (source < 1000000000000000000L) return 18;

                return 19;
            }

            if (source > -10L) return minusIsDigit ? 2 : 1;
            if (source > -100L) return minusIsDigit ? 3 : 2;
            if (source > -1000L) return minusIsDigit ? 4 : 3;
            if (source > -10000L) return minusIsDigit ? 5 : 4;
            if (source > -100000L) return minusIsDigit ? 6 : 5;
            if (source > -1000000L) return minusIsDigit ? 7 : 6;
            if (source > -10000000L) return minusIsDigit ? 8 : 7;
            if (source > -100000000L) return minusIsDigit ? 9 : 8;
            if (source > -1000000000L) return minusIsDigit ? 10 : 9;
            if (source > -10000000000L) return minusIsDigit ? 11 : 10;
            if (source > -100000000000L) return minusIsDigit ? 12 : 11;
            if (source > -1000000000000L) return minusIsDigit ? 13 : 12;
            if (source > -10000000000000L) return minusIsDigit ? 14 : 13;
            if (source > -100000000000000L) return minusIsDigit ? 15 : 14;
            if (source > -1000000000000000L) return minusIsDigit ? 16 : 15;
            if (source > -10000000000000000L) return minusIsDigit ? 17 : 16;
            if (source > -100000000000000000L) return minusIsDigit ? 18 : 17;
            if (source > -1000000000000000000L) return minusIsDigit ? 19 : 18;

            return minusIsDigit ? 20 : 19;
        }

        /// <summary>
        /// Determines whether the partiy of a long is even.
        /// </summary>
        /// <param name="source">Long to check.</param>
        /// <returns>True if the long is even; otherwise false.</returns>
        public static bool IsEven(this long source)
        {
            return source.IsMultipleOf(2);
        }

        /// <summary>
        /// Determines whether the partiy of a long is odd.
        /// </summary>
        /// <param name="source">Long to check.</param>
        /// <returns>True if the long is odd; otherwise false.</returns>
        public static bool IsOdd(this long source)
        {
            return !IsEven(source);
        }

        /// <summary>
        /// Determines if a long is a multiple of another long.
        /// </summary>
        /// <param name="source">Long to check.</param>
        /// <param name="value">Value.</param>
        /// <returns>True if long is a multiple of the value; otherwise returns false.</returns>
        public static bool IsMultipleOf(this long source, long value)
        {
            if (value == 0)
                return true;
            
            return source % value == 0;
        }

        /// <summary>
        /// Make a long negative (if it isn't already so).
        /// </summary>
        /// <param name="source">Long to make negative.</param>
        /// <returns>The long as a negative.</returns>
        public static long MakeNegative(this long source)
        {
            return source <= 0 ? source : source * -1;
        }

        /// <summary>
        /// Returns the long as a zero padded string.
        /// </summary>
        /// <param name="source">Long to return as a zero padded string.</param>
        /// <param name="length">The expected length of the string.</param>
        /// <returns>Zero padded string representation of the long.</returns>
        public static string ToStringZeroPadded(this long source, int length)
        {
            if (source < 0)
                return source.ToString();

            if (length < 0)
                length = 0;

            return source.ToString().PadLeft(length, '0');
        }
    }
}