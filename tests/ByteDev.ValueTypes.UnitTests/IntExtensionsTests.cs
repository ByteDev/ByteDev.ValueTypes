using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class IntExtensionsTests
    {
        [TestFixture]
        public class IsMultipleOf
        {
            [TestCase(-4, -2)]
            [TestCase(-4, 2)]
            [TestCase(-1, -1)]
            [TestCase(0, 0)]
            [TestCase(0, 1)]
            [TestCase(1, 0)]
            [TestCase(1, 1)]
            [TestCase(2, 1)]
            [TestCase(2, 2)]
            [TestCase(4, 2)]
            public void WhenIsMultipleOf_ThenReturnTrue(int sut, int value)
            {
                var result = sut.IsMultipleOf(value);

                Assert.That(result, Is.True);
            }

            [TestCase(-2, -3)]
            [TestCase(-2, 3)]
            [TestCase(-1, -2)]
            [TestCase(1, 2)]
            [TestCase(2, 3)]
            public void WhenIsNotMultipleOf_ThenReturnFalse(int sut, int value)
            {
                var result = sut.IsMultipleOf(value);

                Assert.That(result, Is.False);
            }
        }

        [TestFixture]
        public class MakeNegative
        {
            [TestCase(-2, -2)]
            [TestCase(-1, -1)]
            [TestCase(0, 0)]
            [TestCase(1, -1)]
            [TestCase(2, -2)]
            public void WhenCalled_ThenMakesIntNegative(int sut, int expected)
            {
                var result = sut.MakeNegative();

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class IsEven
        {
            [TestCase(-4)]
            [TestCase(-2)]
            [TestCase(0)]
            [TestCase(2)]
            [TestCase(4)]
            public void WhenIsEven_ThenReturnTrue(int sut)
            {
                var result = sut.IsEven();

                Assert.That(result, Is.True);
            }

            [TestCase(-3)]
            [TestCase(-1)]
            [TestCase(1)]
            [TestCase(3)]
            public void WhenIsNotEven_ThenReturnFalse(int sut)
            {
                var result = sut.IsEven();

                Assert.That(result, Is.False);
            }
        }

        [TestFixture]
        public class IsOdd
        {
            [TestCase(-3)]
            [TestCase(-1)]
            [TestCase(1)]
            [TestCase(3)]
            public void WhenIsOdd_ThenReturnTrue(int sut)
            {
                var result = sut.IsOdd();

                Assert.That(result, Is.True);
            }

            [TestCase(-4)]
            [TestCase(-2)]
            [TestCase(0)]
            [TestCase(2)]
            [TestCase(4)]
            public void WhenIsNotOdd_ThenReturnFalse(int sut)
            {
                var result = sut.IsOdd();

                Assert.That(result, Is.False);
            }
        }

        [TestFixture]
        public class GetDigits
        {
            [TestCase(-2147483648, 11)]
            [TestCase(-100, 4)]
            [TestCase(-10, 3)]
            [TestCase(-1, 2)]
            [TestCase(0, 1)]
            [TestCase(1, 1)]
            [TestCase(10, 2)]
            [TestCase(100, 3)]
            [TestCase(2147483647, 10)]
            public void WhenMinusIsDigit_ThenReturnDigits(int sut, int expected)
            {
                var result = sut.GetDigits();

                Assert.That(result, Is.EqualTo(expected));
            }

            [TestCase(-2147483648, 10)]
            [TestCase(-100, 3)]
            [TestCase(-10, 2)]
            [TestCase(-1, 1)]
            [TestCase(0, 1)]
            public void WhenMinusIsNotDigit_ThenReturnDigits(int sut, int expected)
            {
                var result = sut.GetDigits(false);

                Assert.That(result, Is.EqualTo(expected));
            }
        }

        [TestFixture]
        public class ToStringZeroPadded : IntExtensionsTests
        {
            [Test]
            public void WhenSourceIsNegative_ThenReturnNoPadding()
            {
                int sut = -1;

                var result = sut.ToStringZeroPadded(3);

                Assert.That(result, Is.EqualTo(sut.ToString()));
            }

            [TestCase(1, -1)]
            [TestCase(1, 0)]
            public void WhenLengthIsZeroOrNegative_ThenReturnNoPadding(int source, int length)
            {
                var result = source.ToStringZeroPadded(length);

                Assert.That(result, Is.EqualTo(source.ToString()));
            }

            [TestCase(0, 1)]
            [TestCase(1, 1)]
            [TestCase(10, 2)]
            public void WhenLengthEqualsNumberOfDigits_ThenReturnNoPadding(int source, int length)
            {
                var result = source.ToStringZeroPadded(length);

                Assert.That(result, Is.EqualTo(source.ToString()));
            }

            [TestCase(0, 2, "00")]
            [TestCase(1, 2, "01")]
            [TestCase(1, 3, "001")]
            [TestCase(10, 3, "010")]
            [TestCase(10, 4, "0010")]
            public void WhenLengthGreaterThanNumberOfDigits_ThenReturnPadded(int source, int length, string expected)
            {
                var result = source.ToStringZeroPadded(length);

                Assert.That(result, Is.EqualTo(expected));
            }
        }
    }
}