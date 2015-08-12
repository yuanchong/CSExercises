using System;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            double cost = 2.4;
            distance -= 0.5;

            if (distance > 0)
            {
                if (distance <= 8.5)
                {
                    cost += Math.Ceiling(distance*10) *0.04;
                }
                else if (distance > 8.5)
                {
                    distance -= 8.5;
                    cost += 3.4;
                    cost += Math.Ceiling(distance*10)*0.05;
                }
            }

            Console.WriteLine(cost);

        }
    }
}