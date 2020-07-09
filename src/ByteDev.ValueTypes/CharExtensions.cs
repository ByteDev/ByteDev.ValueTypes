namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Char" />.
    /// </summary>
    public static class CharExtensions
    {
        /// <summary>
        /// Determines if the char is in the range [a-z].
        /// </summary>
        /// <param name="source">Char to check.</param>
        /// <returns>True the character is lower case; otherwise false.</returns>
        public static bool IsLowerCase(this char source)
        {
            return source >= 'a' && source <= 'z';
        }

        /// <summary>
        /// Determines if the char is in the range [A-Z].
        /// </summary>
        /// <param name="source">Char to check.</param>
        /// <returns>True the character is upper case; otherwise false.</returns>
        public static bool IsUpperCase(this char source)
        {
            return source >= 'A' && source <= 'Z';
        }
    }
}