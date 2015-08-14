using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input distance(km):");
            double d = Convert.ToDouble(Console.ReadLine());
            double c = d * 0.4 + 2.4;
            c = Math.Ceiling(10 * c);
            Console.WriteLine("Your fare is : {0:0.00}", c * 0.1);
        }
    }
}
