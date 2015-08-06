using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex08Test
    {
        [TestMethod]
        public void Ex08TestWithZero()
        {
            TestHelper.TestWithIO(typeof(Ex08), "0\r\n", 32.ToString());
        }

        [TestMethod]
        public void Ex08TestWithRandomPositiveNumber()
        {
            Random r = new Random();
            double n = r.Next(1, 100);
            TestHelper.TestWithIO(typeof(Ex08), n + "\r\n", (n*1.8 + 32).ToString());
        }

        [TestMethod]
        public void Ex08TestWithRandomNegativeNumber()
        {
            Random r = new Random();
            double n = r.Next(-100, -1);
            TestHelper.TestWithIO(typeof(Ex08), n + "\r\n", (n * 1.8 + 32).ToString());
        }

    }
}
