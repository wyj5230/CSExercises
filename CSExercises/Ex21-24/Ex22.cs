using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PLZ input B:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            int d=a;
            int e=b;
            while (a!=b)
            {
                if (a > b)
                {
                    c = a - b;
                    a = c;
                }
                else if (b > a)
                {
                    c = b - a;
                    b = c;
                }
            }
            Console.WriteLine("HCF={0}", a);
            Console.WriteLine("LCM={0}", (d * e) / a);
        }
    }
}
