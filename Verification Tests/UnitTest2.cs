using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Verification_Tests
{
    [TestFixture]
    public class Functional
    {
        [Test]
        public void conditionsVerification()
        {
            string testCondition = "";

            Assert.IsNotEmpty(testCondition);
        }
        
        [Test]
        public void bestRouteVerification()
        {
            Route r1 = new Route();
            Route r2 = new Route();

            Assert.Positive(r1.travelTime());
            Assert.Positive(r2.travelTime());
        }

        [Test]
        public void multipleRoutesVerification()
        {
            int routeCount = 0;
            Route[] routes = new Route[2];
            foreach(Route r in routes)
            {
                routeCount++;
            }

            Assert.Equals(2, routeCount);
        }
      
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
