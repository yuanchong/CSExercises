using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex03Test
    {
        [TestMethod]
        public void Ex03TestWithZero()
        {
            TestHelper.TestOutputEqual(typeof(Ex03), "0\r\n", "0");
        }

        [TestMethod]
        public void Ex03TestWithRandomNumber()
        {
            Random r = new Random();
            double n = Math.Round(r.NextDouble() * 100, 5);
            TestHelper.TestOutputEqual(typeof(Ex03), n + "\r\n", (n * n).ToString());
        }

    }
}
