using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int num = r.Next(1, 10);
            Console.WriteLine("Have your first try (1~9):");
            int t = Convert.ToInt32(Console.ReadLine());
            int a =1;
            while (t != num)
            {
                Console.WriteLine("Oops,PLZ try again:");
                t = Convert.ToInt32(Console.ReadLine());
                a = a + 1;
                if (a > 5)
                {
                    Console.WriteLine("You seem not lucky today:(");
                }

            }
            Console.WriteLine("Got it!You have tried {0} times.", a);
            if (a == 1)
                Console.WriteLine("You are a Wizard!");
            else if (a==2)
                Console.WriteLine("You are a good guess");
            else if (a > 5)
                Console.WriteLine("You are a loser!");
        }
    }
}
