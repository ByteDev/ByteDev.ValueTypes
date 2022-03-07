using System;
using System.Linq;
using ByteDev.Collections;
using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class EnumExtensionsTests
    {
        [TestFixture]
        public class GetDescription : EnumExtensionsTests
        {
            [Test]
            public void WhenHasDescription_ThenReturnDescription()
            {
                var result = DummyEnum.HasDescription.GetDescription();

                Assert.That(result, Is.EqualTo("description"));
            }

            [Test]
            public void WhenHasNoDescription_ThenReturnNull()
            {
                var result = DummyEnum.HasNoDescription.GetDescription();

                Assert.That(result, Is.Null);
            }

            [Test]
            public void WhenValueNotDefined_ThenReturnNull()
            {
                var result = ((DummyEnum)99).GetDescription();

                Assert.That(result, Is.Null);
            }
        }

        [TestFixture]
        public class GetDescriptionOrName : EnumExtensionsTests
        {
            [Test]
            public void WhenHasDescription_ThenReturnDescription()
            {
                var result = DummyEnum.HasDescription.GetDescriptionOrName();

                Assert.That(result, Is.EqualTo("description"));
            }

            [Test]
            public void WhenHasNoDescription_ThenReturnEnumNameAsString()
            {
                var result = DummyEnum.HasNoDescription.GetDescriptionOrName();

                Assert.That(result, Is.EqualTo(DummyEnum.HasNoDescription.ToString()));
            }

            [Test]
            public void WhenValueNotDefined_ThenReturnValueAsString()
            {
                var result = ((DummyEnum)99).GetDescriptionOrName();

                Assert.That(result, Is.EqualTo("99"));
            }
        }

        [TestFixture]
        public class GetFlags
        {
            [Test]
            public void WhenEnumHasNoFlags_ThenReturnEmpty()
            {
                var sut = DummyEnum.HasNoDescription;
                
                var result = sut.GetFlags<DummyEnum>();

                Assert.That(result, Is.Empty);
            }

            [Test]
            public void WhenHasOneValue_ThenReturnSingleFlag()  // No 0 value in enum
            {
                var sut = DummyFlagEnum.Current;

                var result = sut.GetFlags<DummyFlagEnum>();

                Assert.That(result.Single(), Is.EqualTo(DummyFlagEnum.Current));
            }

            [Test]
            public void WhenValueHasMultipleFlags_ThenReturnFlags()
            {
                var sut = DummyFlagEnum.None;
                sut |= DummyFlagEnum.Cached;
                sut |= DummyFlagEnum.Obsolete;

                var result = sut.GetFlags<DummyFlagEnum>().ToList();

                Assert.That(result.First(), Is.EqualTo(DummyFlagEnum.None));
                Assert.That(result.Second(), Is.EqualTo(DummyFlagEnum.Cached));
                Assert.That(result.Third(), Is.EqualTo(DummyFlagEnum.Obsolete));
            }
        }

        [TestFixture]
        public class ToStringOverride
        {
            [Test]
            public void WhenFormatNotHandled_ThenThrowException()
            {
                var sut = TestColor.Red;

                var ex = Assert.Throws<InvalidOperationException>(() => sut.ToString((EnumStringFormat)99));
                Assert.That(ex.Message, Is.EqualTo("Unexpected value 'Red' for enum 'ByteDev.ValueTypes.EnumStringFormat'."));
            }

            [Test]
            public void WhenFormatIsName_ThenReturnName()
            {
                var sut = TestColor.Blue;

                var result = sut.ToString(EnumStringFormat.Name);

                Assert.That(result, Is.EqualTo("Blue"));
            }

            [Test]
            public void WhenFormatIsValue_ThenReturnValueAsString()
            {
                var sut = TestColor.Green;

                var result = sut.ToString(EnumStringFormat.Value);

                Assert.That(result, Is.EqualTo("2"));
            }

            [Test]
            public void WhenFormatIsDescription_AndHasDescription_ThenReturnDescription()
            {
                var sut = TestColor.Blue;

                var result = sut.ToString(EnumStringFormat.Description);

                Assert.That(result, Is.EqualTo("Navy Blue"));
            }

            [Test]
            public void WhenFormatIsDescription_AndNoDescription_ThenReturnNull()
            {
                var sut = TestColor.Red;

                var result = sut.ToString(EnumStringFormat.Description);

                Assert.That(result, Is.Null);
            }

            [Test]
            public void WhenFormatIsDescriptionOrName_AndHasDescription_ThenReturnDescription()
            {
                var sut = TestColor.Blue;

                var result = sut.ToString(EnumStringFormat.DescriptionOrName);

                Assert.That(result, Is.EqualTo("Navy Blue"));
            }

            [Test]
            public void WhenFormatIsDescriptionOrName_AndNoDescription_ThenReturnName()
            {
                var sut = TestColor.Red;

                var result = sut.ToString(EnumStringFormat.DescriptionOrName);

                Assert.That(result, Is.EqualTo("Red"));
            }

            [TestCase(EnumStringFormat.Name, "99")]
            [TestCase(EnumStringFormat.Value, "99")]
            [TestCase(EnumStringFormat.Description, null)]
            [TestCase(EnumStringFormat.DescriptionOrName, "99")]
            public void WhenEnumValueNotDefined(EnumStringFormat format, string expected)
            {
                var sut = (TestColor)99;

                var result = sut.ToString(format);

                Assert.That(result, Is.EqualTo(expected));
            }
        }
    }
}