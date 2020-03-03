using System;
using NUnit.Framework;

namespace Verification_Tests
{
    [TestFixture]
    public class Functional
    {
        [Test]
        public void TestTimerPositive()
        {
            Route rt = new Route();

            Assert.Positive(rt.createTimer());
        }
    }
}
