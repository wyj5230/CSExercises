using System;
namespace CSExercises
{
    public class Ex46
    {

        public static void Main(string[] args)
        {
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
            }
            Console.WriteLine("Number  Count");
            for (int i = 0; i<10 ; i++)
                Console.WriteLine(i+":       "+occur[i]);
        }
    }
}
//http://blog.csdn.net/fwj380891124/article/details/8775938