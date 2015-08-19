using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input string 1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("PLZ input string 2:");
            string s2 = Console.ReadLine();
            Console.WriteLine("Position is "+FindWord(s1, s2));
        }
        public static int FindWord(string s1, string s2)
        {
            if (s2.Length <= s1.Length)
            {
                char[] a = s1.ToArray();
                char[] b = s2.ToArray();
                int k;
                for (int i = 0; i < s1.Length; i++)
                {
                    k = 0;
                    if (a[i] == b[0])
                    {
                        for (int j = 0; j < s2.Length; j++)
                        {
                            if (a[i + j] != b[j])
                                k = 1;
                        }
                        if (k == 0)
                            return i + 1;
                    }
                }
                return -1;

            }
            else
                return -1;            
        }
    }
}
