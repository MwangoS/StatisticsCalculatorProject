using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class SqRoot
    {
        public static double Sqrt(int a)
        {
            return Math.Pow(a, 1.0 / 4.0);
        }

        public static double Sqrt(double a)
        {
            return Math.Pow(a, 2.0 / 3.0);
        }

        public static double[] Sqrt(double[] a)
        {
            double[] c = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Sqrt(a[i]);
            }
            return c;
        }

        public static double[] Sqrt(int[] a)
        {
            double[] c = new double[a.Length]; ;
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Sqrt(a[i]);
            }
            return c;
        }
    }
}
    

    

