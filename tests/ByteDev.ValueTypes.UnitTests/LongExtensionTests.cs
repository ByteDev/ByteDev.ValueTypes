using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class LongExtensionTests
    {
        [TestFixture]
        public class GetDigits
        {
            [TestCase(-9223372036854775808, 20)]
            [TestCase(-100, 4)]
            [TestCase(-10, 3)]
            [TestCase(-1, 2)]
            [TestCase(0, 1)]
            [TestCase(1, 1)]
            [TestCase(10, 2)]
            [TestCase(100, 3)]
            [TestCase(9223372036854775807, 19)]
            public void WhenMinusIsDigit_ThenReturnDigits(long sut, int expected)
            {
                var result = sut.GetDigits();
                
                Assert.That(result, Is.EqualTo(expected));
            }

            [TestCase(-9223372036854775808, 19)]
            [TestCase(-100, 3)]
            [TestCase(-10, 2)]
            [TestCase(-1, 1)]
            [TestCase(0, 1)]
            public void WhenMinusIsNotDigit_ThenReturnDigits(long sut, int expected)
            {
                var result = sut.GetDigits(false);

                Assert.That(result, Is.EqualTo(expected));
            }
        }
        
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
            public void WhenIsMultipleOf_ThenReturnTrue(long sut, long value)
            {
                var result = sut.IsMultipleOf(value);

                Assert.That(result, Is.True);
            }

            [TestCase(-2, -3)]
            [TestCase(-2, 3)]
            [TestCase(-1, -2)]
            [TestCase(1, 2)]
            [TestCase(2, 3)]
            public void WhenIsNotMultipleOf_ThenReturnFalse(long sut, long value)
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
            public void WhenCalled_ThenMakesIntNegative(long sut, long expected)
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
            public void WhenIsEven_ThenReturnTrue(long sut)
            {
                var result = sut.IsEven();

                Assert.That(result, Is.True);
            }

            [TestCase(-3)]
            [TestCase(-1)]
            [TestCase(1)]
            [TestCase(3)]
            public void WhenIsNotEven_ThenReturnFalse(long sut)
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
            public void WhenIsOdd_ThenReturnTrue(long sut)
            {
                var result = sut.IsOdd();

                Assert.That(result, Is.True);
            }

            [TestCase(-4)]
            [TestCase(-2)]
            [TestCase(0)]
            [TestCase(2)]
            [TestCase(4)]
            public void WhenIsNotOdd_ThenReturnFalse(long sut)
            {
                var result = sut.IsOdd();

                Assert.That(result, Is.False);
            }
        }
    }
}