using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int mid;
            int[] A = new int[] {86,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79};
            for (int i = 0; i<A.Length; i++)
            {
                for (int j = i+1;j<A.Length; j++)
                {
                    if (A[i] < A[j])
                    {
                        mid = A[i];
                        A[i] = A[j];
                        A[j] = mid;
                    }
                }
                Console.Write("Pass {0}: \t",i);
                for (int k = 0; k < A.Length; k++)
                    Console.Write(A[k]+" ");
                Console.WriteLine();
            }
            Console.Write("Result: \t");
            for (int k = 0; k < A.Length; k++)
            {
                Console.Write(A[k]+" ");
            }
            Console.WriteLine();
        }
    }
}
