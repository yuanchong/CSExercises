using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:##.00}", Math.Ceiling((2.4 + 0.4 * distance)*10)/10);            
        }
    }
}
