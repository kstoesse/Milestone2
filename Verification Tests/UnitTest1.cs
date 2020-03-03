using System;
using NUnit.Framework;


namespace Verification_Tests
{
    [TestFixture]
    public class Verification
    {
        [Test]
        public void TestTimerCreation()
        {
            Route rt = new Route();

            Assert.IsNotNull(rt.createTimer());
        }

        [Test]
        public void TestTravelConditions()
        {
            Route rt = new Route();

            Assert.IsNotNull(rt.storeConditions());
        }

        [Test]
        public void TestTimerEnded()
        {
            Route rt = new Route();

            Assert.IsNull(rt.endTimer());
        }

        [Test]
        public void TestConditionsDisplayed()
        {
            Route rt = new Route();

            Assert.IsNotNull(rt.displayConditions);
        }

        [Test]
        public void TestFileExists()
        {
            File testFile = new File();

            Assert.IsNotNull(testFile.getFilePath());
        }

        [Test]
        public void TestWriteToFile()
        {
            File testFile = new File();

            Assert.IsNotNull(testFile.writeToFile());
        }
    }

    internal class File
    {
        public string filePath;
        public string writeToFile;

        public string getFilePath()
        {
            filePath = "";
            return filePath;
        }

        public string sendToFile()
        {
            writeToFile = "";
            return writeToFile;
        }
    }

    internal class Route
    {
        public float timer;
        public string[] travelConditions;
        public string display = "";

        public float createTimer()
        {
            timer = 0.0f;
            return timer;
        }

        public string[] storeConditions()
        {
            travelConditions = new string[];
            return travelConditions;
        }

        public float endTimer()
        {
            timer = null;
            return timer;
        }

        public string displayConditions()
        {
            foreach(string s in travelConditions)
            {
                display += s + "\n";
            }

            return display;
        }
    }

}
