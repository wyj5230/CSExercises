using System;
namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
     //       Console.WriteLine("PLZ input a decimal number:");
     //       int i = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= 100; j++)
            {
                Console.Write(Hex1(j)+" ");
                Console.Write(Hex2(j)+"\n");
            }
        }
        //method 1
        public static string Hex1(int i)
        {
            string s =Convert.ToString(i,16);
            return s;
        }
        //method 2
        public static string Hex2(int i)
        {
            string s = i.ToString("x");
            return s;
        }
    }
}
