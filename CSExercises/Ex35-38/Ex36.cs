using System;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input a phrase:");
            string s = Console.ReadLine();
            s = s.ToLower();
            string[] m = new string[s.Length];
            int k = -1;
            for (int i = 0 ; i < s.Length; i++)
                if (s.Substring(i, 1) != " " && s.Substring(i, 1) != "," && s.Substring(i, 1) != "." && s.Substring(i, 1) != "?" && s.Substring(i, 1) != "!")
                {
                    k = k + 1;
                    m[k] = s.Substring(i, 1);
                }
            string a = "", b = "";
            for (int i = 0; i < k+1 ; i++)
            {
                a = a + m[i];
                b = b + m[k  - i];                             
            }
            if (a == b)
                Console.WriteLine("Palindrome!");
            else
                Console.WriteLine("Not palindrome.");            
        }
    }
}
