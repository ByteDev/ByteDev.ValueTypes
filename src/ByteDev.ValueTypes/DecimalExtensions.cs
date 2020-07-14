using System.Globalization;

namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Decimal" />.
    /// </summary>
    public static class DecimalExtensions
    {
        /// <summary>
        /// Gets the number of decimal places.
        /// </summary>
        /// <param name="source">The decimal to perform the operation on.</param>
        /// <param name="ignoreTrailingZeros">True will ignore any trailing zeros set in the decimal point; false not ignore set trailing zeros.</param>
        /// <returns>Number of decimal places.</returns>
        public static int GetNumberDecimalPlaces(this decimal source, bool ignoreTrailingZeros = true)
        {
            var parts = source.ToString(CultureInfo.InvariantCulture).Split('.');

            if (parts.Length < 2)
                return 0;

            if (ignoreTrailingZeros)
                return parts[1].TrimEnd('0').Length;

            return parts[1].Length;
        }

        /// <summary>
        /// Determines if a decimal has any decimal places set.
        /// </summary>
        /// <param name="source">The decimal to perform the operation on.</param>
        /// <param name="ignoreTrailingZeros">True will ignore any trailing zeros set in the decimal point; false not ignore set trailing zeros.</param>
        /// <returns>True if any decimal places are set; otherwise false.</returns>
        public static bool AnyDecimalPlaces(this decimal source, bool ignoreTrailingZeros = true)
        {
            return source.GetNumberDecimalPlaces(ignoreTrailingZeros) > 0;
        }
    }
}