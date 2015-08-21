using System;
namespace CSExercises
{
    public class case1
    {        
        public static void Main(string[] args)
        {
            Console.WriteLine("Input invoice:");
            string input = Console.ReadLine();
            Double num = Convert.ToDouble(input);
            input = input.PadLeft(8, '0');
            string[] a = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] b = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] hun = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };
            {//cent
                if (Convert.ToInt32(input.Substring(6, 1)) == 0)
                {
                    if (Convert.ToInt32(input.Substring(7, 1)) > 1)
                        Console.Write(a[Convert.ToInt32(input.Substring(7, 1)) - 1] + " cent");
                }
                else if (Convert.ToInt32(input.Substring(6, 1)) == 1)
                {
                    Console.Write(b[Convert.ToInt32(input.Substring(7, 1))] + " cent");
                }
                else if (Convert.ToInt32(input.Substring(7, 1)) == 0)
                {
                    Console.Write(hun[Convert.ToInt32(input.Substring(6, 1)) - 2] + "cent");
                }
                else 
                {
                    Console.Write(hun[Convert.ToInt32(input.Substring(6, 1)) - 2] + " " + a[Convert.ToInt32(input.Substring(7, 1)) - 1]+" cent");
                }
            }
        }
    }
}
