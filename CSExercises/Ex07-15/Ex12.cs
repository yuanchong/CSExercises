using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:##.00}",Math.Round(2.4 + 0.4 * distance,1));
        }
    }
}
