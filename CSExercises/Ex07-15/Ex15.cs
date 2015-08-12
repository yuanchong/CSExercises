using System;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter an number between 100-999: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int d1 = n/100;
            int d2 = (n%100)/10;
            int d3 = n%10;

            if (Math.Pow(d1, 3) + Math.Pow(d2, 3) + Math.Pow(d3, 3) == n)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
        }
    }
}