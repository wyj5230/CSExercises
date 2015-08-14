using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;        
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("PLZ input the number:");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x <= 999 && x >= 100)
                {
                    int a = x / 100;
                    int b = x / 10 - a * 10;
                    int c = x - 100 * a - 10 * b;
                    if (x == a * a * a + b * b * b + c * c * c)
                        Console.WriteLine("Congs! {0} is an Armstrong number!", x);
                    else Console.WriteLine("Oops, {0} is not an Armstrong number.", x);
                }
                else Console.WriteLine("invalid input");
            }
            catch
            {
                Console.WriteLine("plz input integer!");
            }
        }
    }
}