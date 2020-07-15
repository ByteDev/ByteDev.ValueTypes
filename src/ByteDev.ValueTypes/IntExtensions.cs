namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Int32" />.
    /// </summary>
    public static class IntExtensions
    {
        /// <summary>
        /// Determines if an int is a multiple of another int.
        /// </summary>
        /// <param name="source">Integer to check.</param>
        /// <param name="value">Value.</param>
        /// <returns>True if int is a multiple of the value; otherwise returns false.</returns>
        public static bool IsMultipleOf(this int source, int value)
        {
            if (value == 0)
                return true;
            
            return source % value == 0;
        }

        /// <summary>
        /// Make an integer negative (if it isn't already so).
        /// </summary>
        /// <param name="source">Integer to make negative.</param>
        /// <returns>The int as a negative.</returns>
        public static int MakeNegative(this int source)
        {
            return source <= 0 ? source : source * -1;
        }

        /// <summary>
        /// Determines whether the partiy of an integer is even.
        /// </summary>
        /// <param name="source">Integer to check.</param>
        /// <returns>True if the integer is even; otherwise false.</returns>
        public static bool IsEven(this int source)
        {
            return source.IsMultipleOf(2);
        }

        /// <summary>
        /// Determines whether the partiy of an integer is odd.
        /// </summary>
        /// <param name="source">Integer to check.</param>
        /// <returns>True if the integer is odd; otherwise false.</returns>
        public static bool IsOdd(this int source)
        {
            return !IsEven(source);
        }

        /// <summary>
        /// Returns the number of digits in an integer.
        /// </summary>
        /// <param name="source">Integer to perform the operation on.</param>
        /// <param name="minusIsDigit">Whether to treat any minus sign as a digit.</param>
        /// <returns>Number of digits in the integer.</returns>
        public static int GetDigits(this int source, bool minusIsDigit = true)
        {
            if (source >= 0)
            {
                if (source < 10) return 1;
                if (source < 100) return 2;
                if (source < 1000) return 3;
                if (source < 10000) return 4;
                if (source < 100000) return 5;
                if (source < 1000000) return 6;
                if (source < 10000000) return 7;
                if (source < 100000000) return 8;
                if (source < 1000000000) return 9;

                return 10;
            }

            if (source > -10) return minusIsDigit ? 2 : 1;
            if (source > -100) return minusIsDigit ? 3 : 2;
            if (source > -1000) return minusIsDigit ? 4 : 3;
            if (source > -10000) return minusIsDigit ? 5 : 4;
            if (source > -100000) return minusIsDigit ? 6 : 5;
            if (source > -1000000) return minusIsDigit ? 7 : 6;
            if (source > -10000000) return minusIsDigit ? 8 : 7;
            if (source > -100000000) return minusIsDigit ? 9 : 8;
            if (source > -1000000000) return minusIsDigit ? 10 : 9;

            return minusIsDigit ? 11 : 10;
        }
    }
}