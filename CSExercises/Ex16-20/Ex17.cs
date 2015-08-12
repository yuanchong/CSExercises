using System;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            switch (gender)
            {
                case "M":
                    if (age >= 40)
                    {
                        Console.Write("Good Morning Uncle " + name);
                    }
                    else
                    {
                        Console.Write("Good Morning Mr. " + name);
                    }
                    break;
                case "F":
                    if (age >= 40)
                    {
                        Console.Write("Good Morning Aunty " + name);
                    }
                    else
                    {
                        Console.Write("Good Morning Ms. " + name);
                    }
                    break;
                default:
                    Console.Write("Wrong gender");
                    break;
            }            
        }
    }
}