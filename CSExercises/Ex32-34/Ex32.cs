using System;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int i, j, k;
            double max, min, sum=0;
            Double[] A = new Double[12];
            for (  i = 0;i<=11;i++)
            {
                Console.WriteLine("PLZ inpute Month{0} sales:", i );
                A[i] = Convert.ToDouble(Console.ReadLine());
            }
            for ( j=0;j<=10;j++)
            {
                if (A[j] > A[j + 1])
                {
                max=A[j];
                A[j] = A[j + 1];
                A[j + 1] = max;
                }
            }
            Console.WriteLine("Maximun Sales:" + A[j]);
            for (k = 0; k <= 10;k++ )
            {
                if (A[k] < A[k + 1])
                {
                    min = A[k];
                    A[k] = A[k + 1];
                    A[k + 1] = min;
                }
            }
            Console.WriteLine("Minimun Sales:" + A[k]);
            for (k = 0; k <= 11; k++)
            {
                sum = sum + A[k];
            }
            Console.WriteLine("Average Sales:" + sum / 12);
        }
    }
}
