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

        [TestFixture]
        public class ToStringWithFlags
        {
            private const string SutString = "ac83abb6-7306-4457-bd26-1f153e2b295b";

            private Guid _sut;

            [SetUp]
            public void SetUp()
            {
                _sut = Guid.Parse(SutString);
            }

            [Test]
            public void WhenNoArgsSpecified_ThenReturnDefaultRepresentation()
            {
                var result = _sut.ToString();

                Assert.That(result, Is.EqualTo("ac83abb6-7306-4457-bd26-1f153e2b295b"));
            }

            [Test]
            public void WhenUseDelimiterIsFalse_ThenReturnString()
            {
                var result = _sut.ToString(GuidStringFlags.NoDelimiters);

                Assert.That(result, Is.EqualTo("ac83abb673064457bd261f153e2b295b"));
                Assert.That(Guid.Parse(result), Is.EqualTo(_sut));
            }

            [Test]
            public void WhenUseUpperCaseIsTrue_ThenReturnString()
            {
                var result = _sut.ToString(GuidStringFlags.UpperCase);
                
                Assert.That(result, Is.EqualTo("AC83ABB6-7306-4457-BD26-1F153E2B295B"));
                Assert.That(Guid.Parse(result), Is.EqualTo(_sut));
            }

            [Test]
            public void WhenUseBracketsIsTrue_ThenReturnString()
            {
                var result = _sut.ToString(GuidStringFlags.Brackets);

                Assert.That(result, Is.EqualTo("{ac83abb6-7306-4457-bd26-1f153e2b295b}"));
                Assert.That(Guid.Parse(result), Is.EqualTo(_sut));
            }

            [Test]
            public void WhenSpecifyingAllArgs_ThenReturnString()
            {
                var result = _sut.ToString(GuidStringFlags.NoDelimiters | GuidStringFlags.UpperCase | GuidStringFlags.Brackets);

                Assert.That(result, Is.EqualTo("{AC83ABB673064457BD261F153E2B295B}"));

                // Note: this representation is not parsable back to a Guid type using Parse method
            }
        }
    }
}
