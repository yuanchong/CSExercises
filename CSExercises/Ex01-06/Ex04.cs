using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double num = Console.ReadLine("Please enter a value: ");
            double rootnum = System.Math.Sqrt (num);
            Console.WriteLine("The square root of "+num+" = "+ rootnum);
        }
    }
}
