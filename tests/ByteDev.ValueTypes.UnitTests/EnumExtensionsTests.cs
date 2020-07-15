using System;
using System.Collections.Generic;
using System.Linq;
using ByteDev.Collections;
using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class EnumExtensionsTests
    {
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
    }
}