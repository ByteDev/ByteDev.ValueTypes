namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Int" />.
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
    }
}