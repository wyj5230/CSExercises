using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            Double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square of the number is {0:0.000}", x * x);
        }
    }
}
