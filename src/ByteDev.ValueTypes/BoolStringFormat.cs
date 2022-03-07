namespace ByteDev.ValueTypes
{
    /// <summary>
    /// Boolean string format.
    /// </summary>
    public enum BoolStringFormat
    {
        /// <summary>
        /// "True" or "False".
        /// </summary>
        TitleCase = 0,

        /// <summary>
        /// "true" or "false".
        /// </summary>
        LowerCase = 1,

        /// <summary>
        /// "TRUE" or "FALSE".
        /// </summary>
        UpperCase = 2,

        /// <summary>
        /// "1" or "0".
        /// </summary>
        Binary = 3,

        /// <summary>
        /// "Yes" or "No".
        /// </summary>
        YesNo = 4,

        /// <summary>
        /// "On" or "Off".
        /// </summary>
        OnOff = 5,

        /// <summary>
        /// "Y" or "N".
        /// </summary>
        YesNoShort = 6
    }
}