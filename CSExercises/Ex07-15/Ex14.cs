using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input a,b,c : ");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            double x = Convert.ToDouble(a);
            double y = Convert.ToDouble(b);
            double z = Convert.ToDouble(c);
            double s = (x + y + z) / 2;
            double S = s * (s - x) * (s - y) * (s - z);
            Console.WriteLine("The area of the triangle is : {0} ", Math.Sqrt(S));
        }
    }
}