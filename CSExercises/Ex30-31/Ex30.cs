using System;
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {            
                int i, j , k = 0;
                for (i = 5; i <= 100; i++,k=0)
                {                    
                        for (j = 1; j <= i; j++)
                        {                            
                            if (i % j == 0)
                            {
                                k = k + 1;
                            }
                        }                    
                       if (k <= 2)                    
                        Console.WriteLine(i);                          
                }            
        }
    }
}
