using System;
namespace CSExercises
{
    public class Ex45
    {
 
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            int num =Convert.ToInt32(amount * 100);
            int i = num / 100;
            int j = num - 100 * i;
            int k = j / 50;
            int l = j - 50 * k;
            int m = l / 20;
            int n = l - 20 * m;
            int o = n / 10;
            int p = n - 10 * o;
            int q = p / 5;
            int r = p - 5 * q;
            if (r!=0)
                Console.WriteLine("Invalid input.");
            else
            {
                Console.WriteLine("100c * " + i);
                Console.WriteLine("50c  * " + k);
                Console.WriteLine("20c  * " + m);
                Console.WriteLine("10c  * " + o);
                Console.WriteLine("5c   * " + q);
            }
        }
    }
}
