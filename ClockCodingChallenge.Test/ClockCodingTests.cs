using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClockCodingChallenge.Test
{
    [TestClass]
    public class ClockCodingTests
    {
        [TestMethod]
        public void TalkingClock_01_00_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("01:00");

            Assert.AreEqual(result, "One o'clock");
        }

        [TestMethod]
        public void TalkingClock_02_00_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("02:00");

            Assert.AreEqual(result, "Two o'clock");
        }

        [TestMethod]
        public void TalkingClock_13_00_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("13:00");

            Assert.AreEqual(result, "One o'clock");
        }

        [TestMethod]
        public void TalkingClock_13_05_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("13:05");

            Assert.AreEqual(result, "Five past One");
        }

        [TestMethod]
        public void TalkingClock_13_10_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("13:10");

            Assert.AreEqual(result, "Ten past One");
        }

        [TestMethod]
        public void TalkingClock_13_25_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("13:25");

            Assert.AreEqual(result, "Twenty five past One");
        }

        [TestMethod]
        public void TalkingClock_13_30_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("13:30");

            Assert.AreEqual(result, "Half past One");
        }

        [TestMethod]
        public void TalkingClock_13_35_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("13:35");

            Assert.AreEqual(result, "Twenty five to Two");
        }

        [TestMethod]
        public void TalkingClock_16_30_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("16:30");

            Assert.AreEqual(result, "Half past Four");
        }

        [TestMethod]
        public void TalkingClock_15_00_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("15:00");

            Assert.AreEqual(result, "Three o'clock");
        }

        [TestMethod]
        public void TalkingClock_00_05_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("00:05");

            Assert.AreEqual(result, "Five past Zero");
        }

        [TestMethod]
        public void TalkingClock_00_30_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("00:30");

            Assert.AreEqual(result, "Half past Zero");
        }

        [TestMethod]
        public void TalkingClock_00_59_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("00:59");

            Assert.AreEqual(result, "One to One");
        }

        [TestMethod]
        public void TalkingClock_23_00_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("23:00");

            Assert.AreEqual(result, "Eleven o'clock");
        }

        [TestMethod]
        public void TalkingClock_23_30_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("23:30");

            Assert.AreEqual(result, "Half past Eleven");
        }

        [TestMethod]
        public void TalkingClock_23_45_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("23:45");

            Assert.AreEqual(result, "Fifteen to Twelve");
        }

        [TestMethod]
        public void TalkingClock_25_45_Invalid_Hour_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("25:45");

            Assert.AreEqual(result, Contants.InvalidTime);
        }

        [TestMethod]
        public void TalkingClock_14_61_Invalid_Minute_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("14:61");

            Assert.AreEqual(result, Contants.InvalidTime);
        }

        [TestMethod]
        public void TalkingClock_14_Invalid_Only_HourOrMinute_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("14");

            Assert.AreEqual(result, Contants.InvalidTime);
        }

        [TestMethod]
        public void TalkingClock_16_Invalid_Only_Hour_With_Colon_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime("16:");

            Assert.AreEqual(result, Contants.InvalidTime);
        }

        [TestMethod]
        public void TalkingClock_16_Invalid_Only_Minute_With_Colon_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime(":16");

            Assert.AreEqual(result, Contants.InvalidTime);
        }

        [TestMethod]
        public void TalkingClock_Invalid_Only_Colon_Test()
        {
            TalkingClock tc = new TalkingClock();
            var result = tc.GetHumanFriendlyTime(":");

            Assert.AreEqual(result, Contants.InvalidTime);
        }
    }
}
