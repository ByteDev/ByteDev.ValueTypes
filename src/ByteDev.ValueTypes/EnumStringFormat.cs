namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Enum string format.
    /// </summary>
    public enum EnumStringFormat
    {
        /// <summary>
        /// Name of the enum value as a string.
        /// </summary>
        Name = 0,

        /// <summary>
        /// Underlying enum number value as a string.
        /// </summary>
        Value = 1,

        /// <summary>
        /// System.ComponentModel.DescriptionAttribute description string.
        /// Null if enum value has no DescriptionAttribute defined.
        /// </summary>
        Description = 2,

        /// <summary>
        /// System.ComponentModel.DescriptionAttribute description string or the enum name
        /// if no DescriptionAttribute is defined.
        /// </summary>
        DescriptionOrName = 3
    }
}