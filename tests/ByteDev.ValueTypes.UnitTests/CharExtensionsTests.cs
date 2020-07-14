using NUnit.Framework;

namespace ByteDev.ValueTypes.UnitTests
{
    [TestFixture]
    public class CharExtensionsTests
    {
        [TestFixture]
        public class Repeat
        {
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
    }
}