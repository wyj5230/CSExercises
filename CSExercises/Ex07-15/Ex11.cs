using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input distance(km):");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your fare is : {0}",d*0.4+2.4);
        }
    }
}
