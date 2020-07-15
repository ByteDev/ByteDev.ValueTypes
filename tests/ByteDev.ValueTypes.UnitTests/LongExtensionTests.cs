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
    }
}