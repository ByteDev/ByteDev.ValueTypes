namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Char" />.
    /// </summary>
    public static class CharExtensions
    {
        /// <summary>
        /// Returns a char repeated a certain number of times as a string.
        /// If length is less than one then empty string will be returned.
        /// </summary>
        /// <param name="source">Char to repeat.</param>
        /// <param name="length">Length of the returned string.</param>
        /// <returns>String of char repeated x times.</returns>
        public static string Repeat(this char source, int length)
        {
            return length < 1 ? string.Empty : new string(source, length);
        }

        /// <summary>
        /// Indicates if the char is the NUL (null) character.
        /// </summary>
        /// <param name="source">Char to check.</param>
        /// <returns>True if the char is NUL (null); otherwise false.</returns>
        public static bool IsNul(this char source)
        {
            return source == '\0';
        }

        /// <summary>
        /// Indicates if the char is in the original ASCII character set.
        /// </summary>
        /// <param name="source">Char to check.</param>
        /// <returns>True if the char is in the ASCII character set; otherwise false.</returns>
        public static bool IsAscii(this char source)
        {
            return source >= 0 && source <= 127;
        }

        /// <summary>
        /// Indicates if the char is considered a ASCII Printable character.
        /// (Space is considered a printable character as is delete (DEL)).
        /// </summary>
        /// <param name="source">Char to check.</param>
        /// <returns>True if the char is considered a ASCII printable character; otherwise false.</returns>
        public static bool IsAsciiPrintable(this char source)
        {
            if (!IsAscii(source))
                return false;

            return source >= 32;
        }

        /// <summary>
        /// Indicates if the char is considered a ASCII Control (non-printable) character.
        /// </summary>
        /// <param name="source">Char to check.</param>
        /// <returns>True if the char is considered a ASCII control character; otherwise false.</returns>
        public static bool IsAsciiControl(this char source)
        {
            if (!IsAscii(source))
                return false;

            return source <= 31;
        }
    }
}