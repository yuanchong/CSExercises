using System;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class Ex02Test
    {
        [TestMethod]
        public void Ex02TestWithZero()
        {
            TestHelper.TestWithIO(typeof(Ex02), "0\r\n", "0");
        }

        [TestMethod]
        public void Ex02TestWithRandomNumber()
        {
            Random r = new Random();
            int n = r.Next(1, 100);
            TestHelper.TestWithIO(typeof(Ex02), n + "\r\n", (n * n).ToString());
        }

    }
}
