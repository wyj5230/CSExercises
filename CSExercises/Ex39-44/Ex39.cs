using System;
namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input an integer (>0):");
            double num = Convert.ToDouble(Console.ReadLine());
            Factorial(num);
        }
        public static void Factorial(double num)
        {
            
            if (num <= 0)
                Console.WriteLine("The integer must be above 0!");
            else
            {
                int i;
                Console.WriteLine("The factorial is as follow:");
                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        Console.WriteLine(i);
                }
            }
            
        }
    }
}
