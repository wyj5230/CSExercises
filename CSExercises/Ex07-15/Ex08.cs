using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double c;
            Console.WriteLine("PLZ input temperature in Centigrade:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The temperature in Fahrenheit is {0}",1.8*c+32);
        }
    }
}
