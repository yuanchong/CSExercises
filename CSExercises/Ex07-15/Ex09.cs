using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter x:");
            string input = Console.ReadLine();
            double x = Convert.ToDouble(input);
            Console.WriteLine((2*x*x)-(4*x)+3);
        }
    }
}
