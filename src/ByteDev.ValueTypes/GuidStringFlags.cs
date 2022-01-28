using System;

namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Flags to help control the string representation of Guids.
    /// </summary>
    [Flags]
    public enum GuidStringFlags
    {
        /// <summary>
        /// Don't use a hyphen delimiter between the parts of the Guid.
        /// </summary>
        NoDelimiters = 0x0002,

        /// <summary>
        /// All hex letters (a-f) will be in uppercase.
        /// </summary>
        UpperCase = 0x0004,

        /// <summary>
        /// Surround the string in curly brackets.
        /// </summary>
        Brackets = 0x0008
    }
}