using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {   try
              {
                        Console.WriteLine("PLZ input name age and gender(M or F):");
                        string n = Console.ReadLine();
                        int a = Convert.ToInt32(Console.ReadLine());
                        string g = Console.ReadLine();
                        switch (g)
                        {
                            case "M":
                                if (a > 0 && a < 40) { Console.WriteLine("good morning Mr.{0}", n); break; }
                                else if (a >= 40) { Console.WriteLine("good morning Uncle {0}", n); break; }
                                else { Console.WriteLine("invalid input"); break; }
                            case "F":
                                if (a > 0 && a < 40) { Console.WriteLine("good morning Ms.{0}", n); break; }
                                else if (a >= 40) { Console.WriteLine("good morning Aunty {0}", n); break; }
                                else { Console.WriteLine("invalid input"); break; }
                            default:
                                Console.WriteLine("invalid input"); break;
                        }
                }
             catch { Console.WriteLine("invalid input"); }
         }
    }
}