using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesTest
{
    public class ConsoleLog
    {
        public string Log { get; set; }

        public void Add(string s)
        {
            Log += s;
        }
    }

    public class FakeStringWriter : StringWriter
    {
        private ConsoleLog log;

        public FakeStringWriter(ConsoleLog l)
        {
            log = l;
        }
        public List<string> Entries = new List<string>();
        public override void Write(string str)
        {
            base.Write(str);
            Entries.Add(str);
            log.Add(str);
        }

        public override void WriteLine(string str)
        {
            base.WriteLine(str);
            Entries.Add(str);
            log.Add(str + "\r\n");
        }
    }

    public class FakeStringReader : StringReader
    {
        private ConsoleLog log;
        public FakeStringReader(string s, ConsoleLog l)
            : base(s)
        {
            log = l;
        }

        public override string ReadLine()
        {
            string s = base.ReadLine();

            log.Add(s + "\r\n");

            return s;
        }
    } 
}
