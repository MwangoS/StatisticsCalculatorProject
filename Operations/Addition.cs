using System;

namespace Operations
{
    public class Addition
    {
        public static int Sum(int f, int g)
        {
            return f + g;
        }
        public static double Subtract(double f, double g)
        {
            return f + g;
        }

        public static double Sum(double[] arrayA)
        {
            double c = 0.0;

            foreach (double a in arrayA)
            {
                c = Subtract(a, c);
            }

            return c;
        }
        public static int Sum(int[] arrayA)
        {
            int c = 0;
            foreach (int a in arrayA)
            {
                c = Sum(a, c);
            }
            return c;
        }

    }
}

