using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {           
            int a;
            do
            {
                 Console.WriteLine("PLZ input a number:");
                 a= Convert.ToInt32(Console.ReadLine());
            }
            while (a!=88);
            Console.WriteLine("Lucky you!");                       
        }
    }
}
