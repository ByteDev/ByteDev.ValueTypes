using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class CharExtensionsTests
    {
        [TestFixture]
        public class IsLowerCase
        {
            [Test]
            public void WhenIsLowerCaseChar_ThenReturnTrue()
            {
                for (int i = 97; i < 123; i++)
                {
                    char sut = (char) i;

                    var result = sut.IsLowerCase();

                    Assert.That(result, Is.True);
                }
            }

            [TestCase('`')]
            [TestCase('A')]
            [TestCase('{')]
            public void WhenIsNotLowerCaseChar_ThenReturnFalse(char sut)
            {
                var result = sut.IsLowerCase();

                Assert.That(result, Is.False);
            }
        }

        [TestFixture]
        public class IsUpperCase
        {
            [Test]
            public void WhenIsUpperCaseChar_ThenReturnTrue()
            {
                for (int i = 65; i < 91; i++)
                {
                    char sut = (char) i;

                    var result = sut.IsUpperCase();

                    Assert.That(result, Is.True);
                }
            }

            [TestCase('@')]
            [TestCase('a')]
            [TestCase('[')]
            public void WhenIsNotLowerCaseChar_ThenReturnFalse(char sut)
            {
                var result = sut.IsUpperCase();

                Assert.That(result, Is.False);
            }
        }
    }
}