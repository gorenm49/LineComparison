﻿using System;

namespace LineComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LineComp l1 = new LineComp(4,6,2,8);
            double line1 = l1.CalculateLength();

            LineComp l2 = new LineComp(7,4,9,6);
            double line2 = l2.CalculateLength();

            if (line1.Equals(line2))
            {
                Console.WriteLine("Both line are equals");
            }
            else
            {
                Console.WriteLine("Both line are not equals");
            }
        }
    }
}