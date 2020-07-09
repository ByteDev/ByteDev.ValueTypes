using NUnit.Framework;
using NUnit.Framework.Internal;

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
    }
}