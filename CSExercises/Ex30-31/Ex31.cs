using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1");
            int i, j=0 ,num;
            for (num = 1; num <=10000; num++,j=0)
            {
                for (i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        j = j + i;
                }
                if (j == num)
                    Console.WriteLine(num);
            }           
        }
    }
}
