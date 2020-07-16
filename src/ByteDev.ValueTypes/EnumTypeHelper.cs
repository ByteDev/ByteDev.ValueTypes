using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Represents a set of helper methods for <see cref="T:System.Enum" />.
    /// </summary>
    public static class EnumTypeHelper
    {
        /// <summary>
        /// Returns a list of possible enum values for the given enum type.
        /// </summary>
        /// <typeparam name="TEnum">The enum type to get as a list.</typeparam>
        /// <returns>List of possible enum values.</returns>
        public static IList<TEnum> ToList<TEnum>() where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .Select(e => e)
                .ToList();
        }

        /// <summary>
        /// Returns a list of possible enum value descriptions for the given enum type.
        /// If a enum value has no Description attribute then the enum value as a string is returned.
        /// </summary>
        /// <typeparam name="TEnum">The enum type to get as a list.</typeparam>
        /// <returns>List of possible enum value's descriptions.</returns>
        public static IList<string> ToDisplayList<TEnum>() where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .Select(e => e.GetDescriptionOrName())
                .ToList();
        }
    }
}