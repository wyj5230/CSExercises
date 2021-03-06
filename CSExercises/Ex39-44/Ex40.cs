using System;
using System.Data.SqlClient;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 25;i++ )
                Console.WriteLine("{0:#.##}",SQT(i));
        }

        public static double SQT(int y)
        {
            Random r = new Random();
            double G = 1 + r.NextDouble() * (y - 1);
            while ((G * G - y) >= 0.00001 || (G * G - y) <= -0.00001)
            {               
                G = (G + y / G) / 2;
            }
            return G ;
        }
    }
}
