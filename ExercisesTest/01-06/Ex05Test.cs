using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex05Test
    {
        [TestMethod]
        public void Ex05TestWithZero()
        {
            TestHelper.TestWithIO(typeof(Ex05), "0\r\n", 0.ToString());
        }

        [TestMethod]
        public void Ex05TestWithRandomNumber()
        {
            Random r = new Random();
            double n = Math.Round(r.NextDouble() * 100, 5);
            TestHelper.TestWithIO(typeof(Ex05), n + "\r\n", String.Format("{0:0.###}",Math.Sqrt(n)));
        }

    }
}
