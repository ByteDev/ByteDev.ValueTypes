namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Char" />.
    /// </summary>
    public static class CharExtensions
    {
        /// <summary>
        /// Returns a char repeated a certain number of times as a string.
        /// </summary>
        /// <param name="source">Char to repeat.</param>
        /// <param name="length">Length of the returned string.</param>
        /// <returns>String of repeated characters.</returns>
        public static string Repeat(this char source, int length)
        {
            if (length < 1)
                return string.Empty;

            return new string(source, length);
        }

        /// <summary>
        /// Determines if the char is the NUL (null) character.
        /// </summary>
        /// <param name="source">Char to check.</param>
        /// <returns>True if the char is NUL (null); otherwise false.</returns>
        public static bool IsNul(this char source)
        {
            return source == '\0';
        }
    }
}