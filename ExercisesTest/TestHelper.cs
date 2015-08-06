using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    class TestHelper
    {
        ConsoleLog l;
        FakeStringWriter tw;
        TextReader tr;

        public TestHelper() 
        {
            l = new ConsoleLog();
            tw = new FakeStringWriter(l);
        }

        public void SetupConsole(string input)
        {
            TextReader tr = new FakeStringReader(input, l);
            Console.SetOut(tw);
            Console.SetIn(tr);
        }

        public void SetupConsole(string[] inputs)
        {
            string input = "";
            foreach (var str in inputs)
            {
                input += str + "\r\n";
            }
            SetupConsole(input);
        }

        public void AssertOutput(string expectedOutput)
        {
            Debug.WriteLine(l.Log);
            Assert.IsTrue(tw.Entries.Count>0,"There is no output detected");
            Assert.AreEqual(expectedOutput.Trim().ToLower(), tw.Entries[tw.Entries.Count - 1].Trim().ToLower(),"Program output is different from the expected output.");
        }

        public static void TestWithIO(Type t,  string input, string output)
        {
            TestHelper help = new TestHelper();

            help.SetupConsole(input);
            var methodInfo =  t.GetMethod("Main");
            if (methodInfo != null)
            {
                methodInfo.Invoke(null,new object[] {null});
            }
            help.AssertOutput(output);
        }
    }
}
