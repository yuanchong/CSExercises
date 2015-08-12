using System;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();

            switch (gender)
            {
                case "M":
                    Console.Write("Good Morning Mr. "+ name);
                    break;
                case "F":
                    Console.Write("Good Morning Ms. "+ name);
                    break;
                default:
                    Console.Write("Wrong gender");
                    break;
            }
        }
    }
}