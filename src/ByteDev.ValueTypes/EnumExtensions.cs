using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Extension methods for <see cref="T:System.Enum" />.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Returns the enum System.ComponentModel.DescriptionAttribute description; otherwise returns null
        /// if the enum has no DescriptionAttribute assigned.
        /// </summary>
        /// <param name="source">The enum to get the description from.</param>
        /// <returns>Enum Description attribute text or null if the enum has no Description attribute.</returns>
        public static string GetDescription(this Enum source)
        {
            var fieldInfo = source.GetType().GetField(source.ToString());

            if (fieldInfo == null)
                return null;

            var attributes = (DescriptionAttribute[]) fieldInfo.GetCustomAttributes(typeof (DescriptionAttribute), false);

            return attributes.Length > 0 ? attributes.First().Description : null;
        }

        /// <summary>
        /// Returns the enum Description attribute text or if the enum has no Description the Enum name as a string is returned.
        /// </summary>
        /// <param name="source">The enum to get the description or name from.</param>
        /// <returns>Enum Description attribute text or the enum name if the enum has no Description attribute.</returns>
        public static string GetDescriptionOrName(this Enum source)
        {
            var description = GetDescription(source);

            return description ?? source.ToString();
        }

        /// <summary>
        /// Gets a collection of all the set flags for an enum value. If the enum
        /// does not have a FlagsAttribute then empty is returned.
        /// </summary>
        /// <typeparam name="TEnum">Enum type.</typeparam>
        /// <param name="source">The enum value to get the flags for.</param>
        /// <returns>Collection of set flags on the enum value.</returns>
        public static IEnumerable<TEnum> GetFlags<TEnum>(this Enum source) where TEnum : Enum
        {
            if (!HasFlagsAttribute<TEnum>())
                return Enumerable.Empty<TEnum>();

            return Enum.GetValues(source.GetType())
                .Cast<Enum>()
                .Where(source.HasFlag)
                .Cast<TEnum>();
        }
        
        /// <summary>
        /// Returns a string representation of the enum value in a given format.
        /// </summary>
        /// <typeparam name="TEnum">Source enum type.</typeparam>
        /// <param name="source">Enum to perform the operation on.</param>
        /// <param name="format">Format of the returned string.</param>
        /// <returns>String in the provided format.</returns>
        /// <exception cref="T:System.InvalidOperationException">Unexpected format value.</exception>
        public static string ToString<TEnum>(this TEnum source, EnumStringFormat format) where TEnum : Enum
        {
            switch (format)
            {
                case EnumStringFormat.Name:
                    return source.ToString();

                case EnumStringFormat.Value:
                    return source.ToString("D");

                case EnumStringFormat.Description:
                    return GetDescription(source);

                case EnumStringFormat.DescriptionOrName:
                    return GetDescriptionOrName(source);

                default:
                    throw new InvalidOperationException($"Unexpected value '{source}' for enum '{typeof(EnumStringFormat).FullName}'.");
            }
        }

        private static bool HasFlagsAttribute<TEnum>() where TEnum : Enum
        {
            return typeof(TEnum).IsDefined(typeof(FlagsAttribute), false);
        }
    }
}