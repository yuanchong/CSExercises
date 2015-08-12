using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter quantity for TV: ");
            int tv = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for DVD: ");
            int dvd = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity for MP3: ");
            int mp3 = Convert.ToInt32(Console.ReadLine());

            double price = tv*900 + dvd*500 + mp3*700;

            double discountRate = 0;
            if (price > 10000)
            {
                discountRate = 0.15;
            } 
            else if (price > 5000)
            {
                discountRate = 0.1;
            }

            double discount = discountRate*(tv*900 + dvd*500);

            Console.WriteLine("Total price for this order is {0:c}", price-discount);

        }
    }
}