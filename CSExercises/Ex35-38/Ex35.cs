using System;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input a phrase:");
            string p = Console.ReadLine();
            string[] s = p.Split();
            string[] r = new String[] {"a","e","i","o","u"};
            int[] a = new int[5];
            int j,k,t=0;
            for ( j = 0 ; j < 5 ; j++)
            {
                k = 0;
                for (int i = 0; i < p.Length; i++)
                {
                    if (s[i] == r[j])
                    {
                        k = k + 1;
                        t = t + 1;
                    }
                }
                
                a[j] = k;
            }
            for (int m = 0; m < 5 ;m++)
            Console.WriteLine("The number of {0} is {1} :",r[m],a[m]);
        }
    }
}

