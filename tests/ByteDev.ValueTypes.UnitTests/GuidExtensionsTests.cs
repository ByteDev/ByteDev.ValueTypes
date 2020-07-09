using System;
using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class GuidExtensionsTests
    {
        [TestFixture]
        public class IsEmpty
        {
            [Test]
            public void WhenGuidIsEmpty_ThenReturnTrue()
            {
                var sut = Guid.Empty;

                var result = sut.IsEmpty();

                Assert.IsTrue(result);
            }

            [Test]
            public void WhenGuidIsDefault_ThenReturnTrue()
            {
                var sut = default(Guid);

                var result = sut.IsEmpty();

                Assert.IsTrue(result);
            }

            [Test]
            public void WhenGuidIsNotEmpty_ThenReturnFalse()
            {
                var sut = Guid.NewGuid();

                var result = sut.IsEmpty();

                Assert.IsFalse(result);
            }
        }

        [TestFixture]
        public class Comb
        {
            [Test]
            public void WhenGuidIsEmpty_ThenThrowException()
            {
                var sut = Guid.Empty;

                Assert.Throws<ArgumentException>(() => sut.Comb());
            }

            [Test]
            public void WhenGuidIsNotEmpty_ThenReturnDifferentGuid()
            {
                var sut = Guid.NewGuid();
                var originalId = sut;

                var result = sut.Comb();

                Assert.That(result, Is.Not.EqualTo(sut));
                Assert.That(result.ToString().Substring(0, 20), Is.EqualTo(originalId.ToString().Substring(0, 20)));
            }
        }
    }
}
