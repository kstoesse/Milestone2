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
    }
}
