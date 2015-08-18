using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input distance(km):");
            double d = Convert.ToDouble(Console.ReadLine());
            d = 0.1*Math.Ceiling(10 * d);
            double f;
            if (d<=0.5 && d>0)
                     {
                       f=2.4;
                       Console.WriteLine("Your fare is {0:c}",f);
                     }
            else if (d>0.5 && d<9)
                     {
                       f=2.4+(d-0.5)*0.4;
                       Console.WriteLine("Your fare is {0:c}",f);
                     }
            else if (d>9)
                     {
                        f = 2.4+8.5*0.4+(d-9)*0.5;
                        Console.WriteLine("Your fare is {0:c}", f);
                     }
            else Console.WriteLine("Invalid input.");
        }
    }
}