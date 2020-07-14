using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class DecimalExtensionsTests
    {
        [TestFixture]
        public class GetNumberDecimalPlaces
        {
            [Test]
            public void WhenHasNoNonZeroDecimalPlacesSet_ThenReturnZero()
            {
                decimal[] decimals = { -1, 1, 1.0M, 1.00M, 0, 0.0M, 0.00M };

                ActAndAssert(decimals, 0);
            }

            [Test]
            public void WhenHasOneDecimalPlace_ThenReturnOne()
            {
                decimal[] decimals = { -0.1M, 0.1M, 1.1M };

                ActAndAssert(decimals, 1);
            }

            [Test]
            public void WhenHasTwoDecimalPlaces_ThenReturnTwo()
            {
                decimal[] decimals = { -0.01M, 0.01M, 1.01M, 1.11M };

                ActAndAssert(decimals, 2);
            }

            [Test]
            public void WhenHasTrailingZeros_ThenIgnoreTrailingZeros()
            {
                decimal[] decimals = { 1.230M, 1.2300M };

                ActAndAssert(decimals, 2);
            }

            [Test]
            public void WhenTrailingZerosNotIgnored_ThenIncludeTrailingSetZeros()
            {
                decimal sut = 1.230M;

                var result = sut.GetNumberDecimalPlaces(false);

                Assert.That(result, Is.EqualTo(3));
            }

            private static void ActAndAssert(decimal[] decimals, int expected)
            {
                foreach (var d in decimals)
                {
                    var result = d.GetNumberDecimalPlaces();

                    Assert.That(result, Is.EqualTo(expected));
                }
            }
        }

        [TestFixture]
        public class AnyDecimalPlaces
        {
            [Test]
            public void WhenHasNoDecimalPlacesSet_ThenReturnsFalse()
            {
                var result = 0M.AnyDecimalPlaces();

                Assert.That(result, Is.False);
            }

            [Test]
            public void WhenHasDecimalPlacesSet_ThenReturnTrue()
            {
                var result = 0.1M.AnyDecimalPlaces();

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenIncludeTrailingZeros_AndHasTrailingZeros_ThenReturnTrue()
            {
                var result = 0.0M.AnyDecimalPlaces(false);

                Assert.That(result, Is.True);
            }

            [Test]
            public void WhenIncludeTrailingZeros_AndHasNoTrailingZeros_ThenReturnFalse()
            {
                var result = 0M.AnyDecimalPlaces(false);

                Assert.That(result, Is.False);
            }
        }
    }
}