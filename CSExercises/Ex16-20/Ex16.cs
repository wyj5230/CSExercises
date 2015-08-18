using System;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input name and gender(M or F):");
            string n = Console.ReadLine();
            string g = Console.ReadLine();
            switch (g)
            {
                case "M":
                    Console.WriteLine("good morning Mr.{0}", n); break;
                case "F":
                    Console.WriteLine("good morning Ms.{0}", n); break;
                default:
                    Console.WriteLine("invalid input"); break;
            }
        }
    }
}