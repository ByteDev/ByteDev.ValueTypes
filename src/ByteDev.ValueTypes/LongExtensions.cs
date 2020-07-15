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
    }
}