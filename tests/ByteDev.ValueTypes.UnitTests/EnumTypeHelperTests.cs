using System;
using System.Linq;
using ByteDev.Collections;
using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class EnumTypeHelperTests
    {
        [TestFixture]
        public class ToList
        {
            [Test]
            public void WhenEnumHasZeroValues_ThenReturnEmpty()
            {
                var result = EnumTypeHelper.ToList<ZeroValueEnum>();

                Assert.That(result, Is.Empty);
            }

            [Test]
            public void WhenEnumHasTwoValues_ThenReturnTwo()
            {
                var result = EnumTypeHelper.ToList<DummyEnum>();

                Assert.That(result.Count, Is.EqualTo(2));
                Assert.That(result.First(), Is.EqualTo(DummyEnum.HasDescription));
                Assert.That(result.Second(), Is.EqualTo(DummyEnum.HasNoDescription));
            }
        }

        [TestFixture]
        public class ToList_Type
        {
            [Test]
            public void WhenTypeIsNotEnum_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => EnumTypeHelper.ToList(typeof(object)));
            }

            [Test]
            public void WhenEnumHasZeroValues_ThenReturnEmpty()
            {
                var result = EnumTypeHelper.ToList(typeof(ZeroValueEnum));

                Assert.That(result, Is.Empty);
            }

            [Test]
            public void WhenEnumHasTwoValues_ThenReturnTwo()
            {
                var result = EnumTypeHelper.ToList(typeof(DummyEnum));

                Assert.That(result.Count, Is.EqualTo(2));
                Assert.That(result.First(), Is.EqualTo(DummyEnum.HasDescription));
                Assert.That(result.Second(), Is.EqualTo(DummyEnum.HasNoDescription));
            }
        }

        [TestFixture]
        public class ToDisplayList
        {
            [Test]
            public void WhenEnumHasZeroValues_ThenReturnEmpty()
            {
                var result = EnumTypeHelper.ToDisplayList<ZeroValueEnum>();

                Assert.That(result, Is.Empty);
            }

            [Test]
            public void WhenEnumHasOneWithDescriptionAndOneWithout_ThenReturnTwo()
            {
                var result = EnumTypeHelper.ToDisplayList<DummyEnum>();

                Assert.That(result.Count, Is.EqualTo(2));
                Assert.That(result.First(), Is.EqualTo("description"));
                Assert.That(result.Second(), Is.EqualTo("HasNoDescription"));
            }
        }

        [TestFixture]
        public class ToDisplayList_Type
        {
            [Test]
            public void WhenTypeIsNotEnum_ThenThrowException()
            {
                Assert.Throws<ArgumentException>(() => EnumTypeHelper.ToDisplayList(typeof(object)));
            }

            [Test]
            public void WhenEnumHasZeroValues_ThenReturnEmpty()
            {
                var result = EnumTypeHelper.ToDisplayList(typeof(ZeroValueEnum));

                Assert.That(result, Is.Empty);
            }

            [Test]
            public void WhenEnumHasOneWithDescriptionAndOneWithout_ThenReturnTwo()
            {
                var result = EnumTypeHelper.ToDisplayList(typeof(DummyEnum));

                Assert.That(result.Count, Is.EqualTo(2));
                Assert.That(result.First(), Is.EqualTo("description"));
                Assert.That(result.Second(), Is.EqualTo("HasNoDescription"));
            }
        }

        [TestFixture]
        public class HasFlagsAttribute
        {
            [Test]
            public void WhenEnumHasNoFlagAttribute_ThenReturnFalse()
            {
                var result = EnumTypeHelper.HasFlagsAttribute<ZeroValueEnum>();

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenEnumHasFlagAttribute_ThenReturnTrue()
            {
                var result = EnumTypeHelper.HasFlagsAttribute<DummyFlagEnum>();

                Assert.That(result, Is.True);
            }
        }

        [TestFixture]
        public class HasFlagsAttribute_Type
        {
            [Test]
            public void WhenTypeIsNotEnum_ThenReturnFalse()
            {
                Assert.Throws<ArgumentException>(() => EnumTypeHelper.HasFlagsAttribute(typeof(object)));
            }
        }
    }
}