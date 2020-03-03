using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Verification_Tests
{
    [TestFixture]
    public class Functional
    {
        Skeleton_Class s = new Skeleton_Class(null, 0, 0, 0, null);
        
        [Test, MaxTime(2000)]
        public void meanTest()
        {
            Assert.AreEqual(s.Mean, 0);
        }

        [Test, MaxTime(2000)]
        public void modeTest()
        {
            Assert.AreEqual(s.Mode, 0);
        }

        [Test, MaxTime(2000)]
        public void medianTest()
        {
            Assert.AreEqual(s.Median, 0);
        }

        [Test, MaxTime(2000)]
        public void safetyRangeTest()
        {
            Assert.Null(s.SafetyRange);
        }
        
    }
}
