using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("PLZ input salary:");
            a = Convert.ToDouble(Console.ReadLine());
            b = a * 0.1;
            c = a * 0.03;
            d = a + b + c;
            Console.WriteLine("Your total salary is {0:c}", d);

        }
    }
}
