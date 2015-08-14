using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input x1,y1,x2,y2 coordinates and use enter to seperate");
            string x1 = Console.ReadLine();
            string y1 = Console.ReadLine();
            string x2 = Console.ReadLine();
            string y2 = Console.ReadLine();
            double a = Convert.ToDouble(x1);
            double b = Convert.ToDouble(y1);
            double c = Convert.ToDouble(x2);
            double d = Convert.ToDouble(y2);
            Console.WriteLine("Distance = {0}",Math.Sqrt((c-a)*(c-a)+(d-b)*(d-b)));            
        }
    }
}
