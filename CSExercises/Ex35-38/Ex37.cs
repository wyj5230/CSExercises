using System;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input a phrase:");
            string s = Console.ReadLine();         
            char[] k = new char[] {' ', ',', '.', '!', '?'};
            string[] t = s.Split(k,StringSplitOptions.RemoveEmptyEntries);
            int p = t.Length;
            string[] m = new string[p];
            for (int i=0; i<p; i++)
            {
                m[i] = t[i].Substring(0, 1).ToUpper() + t[i].Substring(1);
                Console.Write(m[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
