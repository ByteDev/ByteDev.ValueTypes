﻿using NUnit.Framework;

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
    }
}