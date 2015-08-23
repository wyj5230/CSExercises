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
            {//thousand
                if (Convert.ToInt32(input.Substring(0, 1)) == 0)
                {
                    if (Convert.ToInt32(input.Substring(1, 1)) >= 1)
                        Console.Write(a[Convert.ToInt32(input.Substring(4, 1)) - 1] + " thousand");
                }
                else if (Convert.ToInt32(input.Substring(0, 1)) == 1)
                {
                    Console.Write(b[Convert.ToInt32(input.Substring(1, 1))] + " thousand");
                }
                else
                {
                    Console.Write(hun[Convert.ToInt32(input.Substring(0, 1)) - 2]);
                    if (Convert.ToInt32(input.Substring(1, 1)) != 0)
                        Console.Write(" "+a[Convert.ToInt32(input.Substring(1, 1)) - 1]);
                    Console.Write(" thousand");
                }
            }
            {//hundred
                if (Convert.ToInt32(input.Substring(2, 1)) > 0)
                    Console.Write(" " + a[Convert.ToInt32(input.Substring(2, 1)) - 1] + " hundred");
            }
            {//0.99
                if (Convert.ToInt32(input.Substring(3, 1)) == 0)
                {
                    if (Convert.ToInt32(input.Substring(4, 1)) >= 1)
                        Console.Write(" "+a[Convert.ToInt32(input.Substring(4, 1)) - 1] + " dollars");
                }
                else if (Convert.ToInt32(input.Substring(3, 1)) == 1)
                {
                    Console.Write(" " + b[Convert.ToInt32(input.Substring(4, 1))] + " dollars");
                }
                else
                {
                    Console.Write(" " + hun[Convert.ToInt32(input.Substring(3, 1)) - 2] + " ");
                    if (Convert.ToInt32(input.Substring(4, 1)) != 0)
                        Console.Write(a[Convert.ToInt32(input.Substring(4, 1)) - 1] + " dollars");
                }
            }
            {//cent
                if (Convert.ToInt32(input.Substring(6, 1)) == 0)
                {
                    if (Convert.ToInt32(input.Substring(7, 1)) >= 1)
                        Console.Write( " and "+a[Convert.ToInt32(input.Substring(7, 1)) - 1] + " cents");
                }
                else if (Convert.ToInt32(input.Substring(6, 1)) == 1)
                {
                    Console.Write(" and "+b[Convert.ToInt32(input.Substring(7, 1))] + " cents");
                }             
                else 
                {
                    Console.Write(" and " + hun[Convert.ToInt32(input.Substring(6, 1)) - 2] + " ");
                        if (Convert.ToInt32(input.Substring(7, 1)) != 0)
                        Console.Write(a[Convert.ToInt32(input.Substring(7, 1)) - 1]+" cents");
                }
            }

        }
    }
}
