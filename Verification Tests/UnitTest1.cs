using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;


namespace Verification_Tests
{
    [TestFixture]
    public class Verification
    {
        [Test]
        public void firstLocationTest()
        {
            Location loc1 = new Location();

            Assert.IsNotNull(loc1);
        }

        [Test]
        public void secondLocationTest()
        {
            Location loc2 = new Location();

            Assert.IsNotNull(loc2);
        }

        [Test]
        public void routeTest()
        {
            Route r1 = new Route();
            Route r2 = new Route();

            Assert.AreNotEqual(r1.path(),r2.path());
        }

        [Test]
        public void TrafficPatternTest()
        {
            string flow = "";

            Traffic t1 = new Traffic();

            Assert.AreEqual(t1.Pattern(), flow);
        }

        [Test]
        public void BestRouteTest()
        {
            Route r1 = new Route();
            Route r2 = new Route();

            if (r1.travelTime() < r2.travelTime())
                Assert.Greater(r2.travelTime(), r1.travelTime());
            else
                Assert.Greater(r1.travelTime(), r2.travelTime());

        }

        [Test]
        public void trafficConditionsTest()
        {
            Route r1 = new Route();
            string testCondition = "";

            Assert.Equals(r1.condition(), testCondition);
        }
    }

    internal class Location
    {
    }

    internal class Route
    {

        public Route path()
        {
            return null;
        }

        public double travelTime()
        {
            return 0.0;
        }

        public string condition()
        {
            return "";
        }
    }

    public class Traffic
    {
        public string Pattern()
        {
            return null;
        }
    }
}
