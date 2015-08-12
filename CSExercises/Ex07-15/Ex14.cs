using System;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double s = (a + b + c)/2;
            Console.WriteLine(Math.Sqrt(s * (s-a) * (s-b) * (s-c)));
        }
    }
}