using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input an integer(above 0):");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                int i, j = 0;
                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        j = j + 1;
                    }

                }
                if (j >= 3)
                    Console.WriteLine("Not Prime");
                else Console.WriteLine("Prime");
            }
            else Console.WriteLine("INPUT MUST ABOVE 0 !");
        }
    }
}
