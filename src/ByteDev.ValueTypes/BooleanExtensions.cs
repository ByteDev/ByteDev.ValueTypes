using System;

namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Boolean" />.
    /// </summary>
    public static class BooleanExtensions
    {
        /// <summary>
        /// Returns a string representation of the boolean value in a given format.
        /// </summary>
        /// <param name="source">Boolean to perform the operation on.</param>
        /// <param name="format">Format of the returned string.</param>
        /// <returns>String in the provided format.</returns>
        /// <exception cref="T:System.InvalidOperationException">Unexpected format value.</exception>
        public static string ToString(this bool source, BoolStringFormat format = BoolStringFormat.TitleCase)
        {
            switch (format)
            {
                case BoolStringFormat.TitleCase:
                    return source.ToString();

                case BoolStringFormat.LowerCase:
                    return source.ToString().ToLowerInvariant();

                case BoolStringFormat.UpperCase:
                    return source.ToString().ToUpperInvariant();

                case BoolStringFormat.Binary:
                    return source ? "1" : "0";

                case BoolStringFormat.YesNo:
                    return source ? "Yes" : "No";

                case BoolStringFormat.OnOff:
                    return source ? "On" : "Off";

                case BoolStringFormat.YesNoShort:
                    return source ? "Y" : "N";

                case BoolStringFormat.EnableDisable:
                    return source ? "Enable" : "Disable";

                default:
                    throw new InvalidOperationException($"Unexpected value '{format}' for enum '{typeof(BoolStringFormat).FullName}'.");
            }
        }
    }
}