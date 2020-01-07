﻿using System;

namespace Operations2
{
    public class Cube
    {
        public static int Cubed(int a)
        {
            return Multiplication.Times(a, Square.Squared(a));
        }

        public static double Cubed(double a)
        {
            return Multiplication.Times(a, Square.Squared(a));
        }

        public static double[] Cubed(double[] a)
        {
            double[] c = new double[a.Length];
            for(int i = 0; i<a.Length; i++)
            {
                c[i] = Cubed(a[i]);
            }
            return c;
        }

        public static int[] Cubed(int[] a)
        {
            int[] c = new int[a.Length]; ;
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Cubed(a[i]);
            }
            return c;
        }
    }
}