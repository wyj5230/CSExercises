using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] n = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            string[] m = new string[] { "63", "29", "75", "82", "55" };
/*num*/     int[] s = new int[5];
            for (int i = 0; i < 5; i++)
            {                
                s[i] = Convert.ToInt32(m[i]);
            }
            //part a
            int mid;
            string MID;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] < s[j])
                    {
                        mid = s[i];
                        MID = n[i];
                        s[i] = s[j];
                        n[i] = n[j];
                        s[j] = mid;
                        n[j] = MID;
                    }
                }
            }
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(n[i] + ":\t" + s[i]);
            Console.WriteLine();
            //part b
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (n[i].CompareTo(n[j])==1)
                    {
                        mid = s[i];
                        MID = n[i];
                        s[i] = s[j];
                        n[i] = n[j];
                        s[j] = mid;
                        n[j] = MID;
                    }
                }
            }
            for (int i = 0; i < s.Length; i++)
                Console.WriteLine(n[i] + ":\t" + s[i]);
        }
    }
}
