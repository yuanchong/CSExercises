using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex06Test
    {
        [TestMethod]
        public void Ex06TestWithZero()
        {
            TestHelper.TestWithIO(typeof(Ex06), "0\r\n", 0.ToString());
        }

        [TestMethod]
        public void Ex06TestWithRandomNumber()
        {
            Random r = new Random();
            double n = r.Next(1, 100);
            TestHelper.TestWithIO(typeof(Ex06), n + "\r\n", String.Format("{0:0.###}",Math.Sqrt(n)));
        }

    }
}
