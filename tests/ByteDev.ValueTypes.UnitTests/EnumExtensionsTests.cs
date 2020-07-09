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
    }
}