using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input an integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
                Console.WriteLine("Perfect number");
            else
            {
                int i, j = 0;
                for (i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        j = j + i;
                }
                if (j == num)
                    Console.WriteLine("Perfect Number");
                else Console.WriteLine("Not Perfect Number");
            }
        }
    }
}
