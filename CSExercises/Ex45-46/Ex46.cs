using System;
namespace CSExercises
{
    public class Ex46
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Number  Count");
            int[] occur = new int[10];
            int[] num = new int[50];
            Random r = new Random();
            int k = 0;
            for (int i = 0; i < 50; i++)
                num[i] = r.Next(0, 10);
            for (int i = 0; i < 10; i++, k = 0)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (num[j] == i)
                        k = k + 1;
                }
                occur[i] = k;
                Console.WriteLine(i + ":       " + occur[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + ":       ");
                for (int j = 0; j < occur[i]; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
            //Console.WriteLine("Number  Count");
            //int[] occur = new int[10];
            //int[] num = new int[50];
            //Random r = new Random();
            //int k = 0;
            //for (int i = 0; i < 50; i++)
            //    num[i] = r.Next(-5, 6);
            //for (int i = -5; i < 5; i++, k = 0)
            //{
            //    for (int j = 0; j < 50; j++)
            //    {
            //        if (num[j] == i)
            //            k = k + 1;
            //    }
            //    occur[i+5] = k;
            //    Console.WriteLine(i + "\t " + occur[i+5]);
            //}
            //Console.WriteLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    string b="";
            //    if (i>=5)
            //    {
            //        Console.Write(i-5 + ":           "+b.PadRight(occur[i],'*'));
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.Write(i - 5 + ":" + b.PadLeft(10 - occur[i], ' ') + b.PadRight(occur[i], '*'));
            //        Console.WriteLine();
            //    }
            //}
        }
    }
}
//http://blog.csdn.net/fwj380891124/article/details/8775938