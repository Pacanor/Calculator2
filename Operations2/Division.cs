using System;

namespace Operations2
{
    public class Division
    {
        public static int Over(int a, int b)
        {
            return a / b;
        }

        public static double Over(double a, double b)
        {
            return a / b;
        }

        public static double Over(double[] a)
        {
            double c = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                c = Over(c, a[i]);
            }
            return c;
        }

        public static int Over(int[] a)
        {
            int c = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                c = Over(c, a[i]);
            }
            return c;
        }
    }
}
