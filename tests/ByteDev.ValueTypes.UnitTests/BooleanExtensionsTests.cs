using System;
using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class BooleanExtensionsTests
    {
        [TestFixture]
        public class ToStringOverride
        {
            [TestCase(BoolStringFormat.TitleCase, "True")]
            [TestCase(BoolStringFormat.LowerCase, "true")]
            [TestCase(BoolStringFormat.UpperCase, "TRUE")]
            [TestCase(BoolStringFormat.Binary, "1")]
            [TestCase(BoolStringFormat.YesNo, "Yes")]
            [TestCase(BoolStringFormat.OnOff, "On")]
            [TestCase(BoolStringFormat.YesNoShort, "Y")]
            [TestCase(BoolStringFormat.EnableDisable, "Enable")]
            public void WhenTypeIsDefined_AndTrue_ThenReturnString(BoolStringFormat format, string expected)
            {
                var result = true.ToString(format);

                Assert.That(result, Is.EqualTo(expected));
            }

            [TestCase(BoolStringFormat.TitleCase, "False")]
            [TestCase(BoolStringFormat.LowerCase, "false")]
            [TestCase(BoolStringFormat.UpperCase, "FALSE")]
            [TestCase(BoolStringFormat.Binary, "0")]
            [TestCase(BoolStringFormat.YesNo, "No")]
            [TestCase(BoolStringFormat.OnOff, "Off")]
            [TestCase(BoolStringFormat.YesNoShort, "N")]
            [TestCase(BoolStringFormat.EnableDisable, "Disable")]
            public void WhenTypeIsDefined_AndFalse_ThenReturnString(BoolStringFormat format, string expected)
            {
                var result = false.ToString(format);

                Assert.That(result, Is.EqualTo(expected));
            }

            [Test]
            public void WhenTypeIsNotDefined_ThenThrowException()
            {
                Assert.Throws<InvalidOperationException>(() => true.ToString((BoolStringFormat) 999));
            }
        }
    }
}