using System;
using System.Collections.Generic;
using System.Text;

namespace Operations2
{
    public class Subtraction
    {
        public static int Dif(int a, int b)
        {
            return a - b;
        }

        public static double Dif(double a, double b)
        {
            return a - b;
        }

        public static double Dif(double[] a)
        {
            double c = 0.0;
            foreach (double b in a)
            {
                c = Dif(c, b);
            }
            return c;
        }

        public static int Dif(int[] a)
        {
            int c = 0;
            foreach (int b in a)
            {
                c = Dif(c, b);
            }
            return c;
        }
    }
}

