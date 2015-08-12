using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your salary:");
            string input = Console.ReadLine();
            double salary = Convert.ToDouble(input);
            Console.WriteLine("{0:c}",salary * 1.13);
        }
    }
}
