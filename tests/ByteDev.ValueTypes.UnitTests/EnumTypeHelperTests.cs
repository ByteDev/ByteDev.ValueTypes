using System.Linq;
using ByteDev.Collections;
using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class EnumTypeHelperTests
    {
        public enum ZeroValueEnum
        {
        }

        [TestFixture]
        public class ToList : EnumExtensionsTests
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
        public class ToDisplayList : EnumExtensionsTests
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
    }
}