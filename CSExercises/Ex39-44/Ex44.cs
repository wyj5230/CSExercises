using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLZ input s, c1, c2: ");
            string s = Convert.ToString(Console.ReadLine());
            char c1 = Convert.ToChar(Console.ReadLine());
            char c2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("The new string is : " + Substitute(s, c1, c2));
        }
        public static string Substitute(string s, char c1, char c2)
        {            
            if (s.Length<1)
            return "Oops, original string doesn't found.";
            else
            {
                int i;
                string t="";
                char[] st=s.ToArray();
                for(i=0;i<s.Length;i++)
                {
                    if (st[i] == c1)
                        st[i] = c2;
                }
                for (i = 0; i < s.Length; i++)
                    t = t + st[i];
                return t;
            }
        }
    }
}
