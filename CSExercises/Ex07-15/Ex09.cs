using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            double x;
            Console.WriteLine("PLZ input x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y = {0}", x*x*2-4*x+3);
        }
    }
}
