using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Verification_Tests
{
    
    [TestFixture]
    public class Verification
    {
        Skeleton_Class s = new Skeleton_Class(null, 0, 0, 0, null);
        [Test]
        public void meanVerTest()
        {
            Assert.Positive(s.Mean);
        }

        [Test]
        public void medianVerTest()
        {
            Assert.Positive(s.Median);
        }

        [Test]
        public void modeVerTest()
        {
            Assert.Positive(s.Mode);
        }

        [Test]
        public void safetyRangeVerTest()
        {
            Assert.IsNotNull(s.SafetyRange);
        }
    }
}
