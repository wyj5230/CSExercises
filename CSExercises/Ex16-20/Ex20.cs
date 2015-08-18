using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity of TV:");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity of DVD:");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity of MP3:");
            int m = Convert.ToInt32(Console.ReadLine());
            int T = 900 * t;
            int D = 500 * d;
            int M = 700 * m;
            double p;
            if (t < 0 || d < 0 || m < 0) Console.WriteLine("Invalid input.");
            else if (T + D <= 5000 && T + D >= 0)
            {
                p = T + D + M;
                Console.WriteLine("Total price for this order is {0:c}.", p);
            }
            else if (T+D >= 5000 && T+D < 10000)
            {
                p = (T + D) * 0.9 + M;
                Console.WriteLine("Total price for this order is {0:c}.", p);
            }
            else if (T+D >= 10000)
            {
                p = (T + D) * 0.85 + M;
                Console.WriteLine("Total price for this order is {0:c}.", p);
            }            
        }
    }
}