using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ in put the number:");
            Double n = Convert.ToDouble(Console.ReadLine());
            Random r = new Random();
            double G = 1+r.NextDouble()*(n-1);
            while ((G * G - n) >= 0.00001 || (G * G - n) <= -0.00001)
            {               
                Console.WriteLine("G={0}", G);
                Console.WriteLine("G*G={0}", G * G);
                Console.WriteLine("n={0}", n);
                G = (G + n / G) / 2;
            }
            Console.WriteLine("The final G={0}", G);
            Console.WriteLine("G*G={0}", G * G);
            Console.WriteLine("n={0}", n);
        }
    }
}
