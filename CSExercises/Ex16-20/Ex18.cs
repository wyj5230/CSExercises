using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input your mark:");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m >= 80 && m <= 100) Console.WriteLine("You scored {0} marks which is A grade.", m);
            else if (m >= 60 && m <= 79) Console.WriteLine("You scored {0} marks which is B grade.", m);
            else if (m >= 40 && m <= 59) Console.WriteLine("You scored {0} marks which is C grade.", m);
            else if (m >= 0 && m <= 40) Console.WriteLine("You scored {0} marks which is F grade.", m);
            else Console.WriteLine("**Error**");
        }
    }
}