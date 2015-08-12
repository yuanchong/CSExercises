using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int x = Convert.ToInt32(s);

            Console.WriteLine("{0:0.###}", Math.Sqrt(x)); 
        }
    }
}
