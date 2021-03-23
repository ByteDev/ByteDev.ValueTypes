using System;

namespace ByteDev.ValueTypes.UnitTests
{
    public enum ZeroValueEnum
    {
    }

    public enum DummyEnum
    {
        [System.ComponentModel.Description("description")]
        HasDescription,
        HasNoDescription,
    }

    [Flags]
    public enum DummyFlagEnum
    {
        None = 1,
        Cached = 2,
        Current = 4,
        Obsolete = 8
    }
}