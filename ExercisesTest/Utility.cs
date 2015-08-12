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
        private int cursor = 0; //index for the new line - when it's pointing to new line, cursor can be = Entries.count

        public FakeStringWriter(ConsoleLog l)
        {
            log = l;
        }
        public List<string> Entries = new List<string>();
        public override void Write(string str)
        {
            base.Write(str);
            if (Entries.Count == cursor)
            {
                Entries.Add(str);
            }
            else
            {
                Entries[cursor] = Entries[cursor] + str;
            }
            log.Add(str);
        }

        public override void WriteLine(string str)
        {
            base.WriteLine(str);
            Entries.Add(str);
            cursor++;
            log.Add(str + "\r\n");
        }

        public override void WriteLine()
        {
            cursor++;
            log.Add("\r\n");
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
