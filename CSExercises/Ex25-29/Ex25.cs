using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
/*
//part 1
            Console.WriteLine("Input an integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num<=0)
                Console.WriteLine("The integer must be above 0!");
            else
            {
                    int i;
                    Console.WriteLine("The factorial is as follow:");
                    for (i=1;i<=num;i++)
                    {
                        if (num % i == 0)
                            Console.WriteLine(i);
                    }
            }
*/
//part 2
            Console.WriteLine("Input an integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0)
                Console.WriteLine("The integer must be above 0!");
            else
            {
                int i;
                Console.WriteLine("The factorial is as follow:");
                for (i = num; i >0; i--)
                {
                    if (num % i == 0)
                        Console.WriteLine(i);
                }
            }
            

        }
    }
}
