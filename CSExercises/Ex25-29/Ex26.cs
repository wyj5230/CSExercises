using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" NO\t\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            Console.WriteLine("-------------------------------------------------------");
           double i,a,b,c;
            for (i=1;i<=10;i++)
            {
                a = 1 / i;
                b = Math.Sqrt(i);
                c = i * i;
                Console.WriteLine(" {0:0.0}\t\t{1:0.0##}\t\t{2:0.0##}\t\t{3:0.0}",i,a,b,c);
            }
        }
    }
}
