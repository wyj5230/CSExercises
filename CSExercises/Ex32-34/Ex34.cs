using System;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
//part 1
            Double[,] marks = new Double[,] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };
            int a = marks.GetLength(0);
            int b = marks.GetLength(1);
            int i, j;
            Double s = 0;
            Double[] sums = new Double[a];
            Double[] sumc = new Double[b];
            Double[] varc = new Double[b];
            Double[] averc =new Double[b];
            for (i = 0; i < a ; i++,s=0)
            {
                for (j = 0; j < b ; j++)
                {
                    s = s + marks[i, j];
                }
                sums[i] = s;
            }
            for (int k = 0; k < a; k++)
            {
                Console.WriteLine("Total marks of student "+k+" :\t"+sums[k]);
            }
            Console.WriteLine();
//part 2a
            for (j = 0; j < b; j++,s=0)
            {
                for (i = 0; i < a; i++)
                {
                    s = s + marks[i, j];
                }
                sumc[j] = s;
                averc[j]=s/12;
            }
            for (int k = 0; k < b; k++)
            {
                Console.WriteLine("Class average of subject" + k + " is :\t{0:#.###}" ,averc[k]);
            }
            Console.WriteLine();
//part 2b   
            for (j = 0; j < b; j++, s = 0)
            {
                for (i = 0; i < a; i++)
                {
                   s=s+ (marks[i, j] - averc[j]) * (marks[i, j] - averc[j]);
                }
                varc[j] = s/a;
            }
            for (int k = 0; k < b; k++)
            {
                Console.WriteLine("Standard deviation of marks for subject" + k + " is :\t{0:#.###}" ,Math.Sqrt(varc[k]));
            }
            Console.WriteLine();
//part 3
            s = 0;
            for (i = 0; i < a; i++)
            {
                for (j = 0; j < b; j++)
                {
                    s = s + marks[i, j];
                }                
            }
            Console.WriteLine("The overall average is: {0}", s / 48);
            Console.WriteLine();
//part 3 method 2
            s = 0;
            for (int k = 0; k < b; k++)
                s = s + sumc[k];
            Console.WriteLine("The overall average is: {0}", s / 48);
            Console.WriteLine();
        }
    }
}
