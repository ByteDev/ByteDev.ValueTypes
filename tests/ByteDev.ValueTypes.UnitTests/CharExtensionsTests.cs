using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class CharExtensionsTests
    {
        [TestFixture]
        public class Repeat
        {
            [TestCase(-1)]
            [TestCase(0)]
            public void WhenLengthIsLessThanOne_ThenReturnEmpty(int length)
            {
                var result = 'A'.Repeat(length);

                Assert.That(result, Is.Empty);
            }

            [TestCase(-1, "")]
            [TestCase(0, "")]
            [TestCase(1, "A")]
            [TestCase(2, "AA")]
            [TestCase(3, "AAA")]
            public void WhenCalled_ThenReturnsString(int count, string expected)
            {
                var result = 'A'.Repeat(count);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class IsNul
        {
            [Test]
            public void WhenCharIsNul_ThenReturnTrue()
            {
                var result = '\0'.IsNul();

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenCharIsNotNull_ThenReturnFalse()
            {
                var result = 'A'.IsNul();

                Assert.That(result, Is.False);
            }
        }

        [TestFixture]
        public class IsAscii
        {
            [Test]
            public void WhenIsNotAscii_ThenReturnFalse()
            {
                var result = ((char)128).IsAscii();

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenIsAscii_ThenReturnTrue()
            {
                for (var i = 0; i < 128; i++)
                {
                    var result = ((char)i).IsAscii();

                    Assert.That(result, Is.True);
                }
            }
        }

        [TestFixture]
        public class IsAsciiPrintable
        {
            [Test]
            public void WhenIsNotAscii_ThenReturnFalse()
            {
                var result = ((char)128).IsAsciiPrintable();

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenIsAsciiNonPrintableChar_ThenReturnFalse()
            {
                for (var i = 0; i < 32; i++)
                {
                    var result = ((char)i).IsAsciiPrintable();

                    Assert.That(result, Is.False);
                }
            }

            [Test]
            public void WhenIsAsciiPrintableChar_ThenReturnTrue()
            {
                for (var i = 32; i < 128; i++)
                {
                    var result = ((char)i).IsAsciiPrintable();

                    Assert.That(result, Is.True);
                }
            }
        }

        [TestFixture]
        public class IsAsciiControl
        {
            [Test]
            public void WhenIsNotAscii_ThenReturnFalse()
            {
                var result = ((char)128).IsAsciiControl();

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenIsAsciiPrintableChar_ThenReturnFalse()
            {
                for (var i = 32; i < 128; i++)
                {
                    var result = ((char)i).IsAsciiControl();

                    Assert.That(result, Is.False);
                }
            }

            [Test]
            public void WhenIsAsciiControlChar_ThenReturnTrue()
            {
                for (var i = 0; i < 32; i++)
                {
                    var result = ((char)i).IsAsciiControl();

                    Assert.That(result, Is.True);
                }
            }
        }
    }
}