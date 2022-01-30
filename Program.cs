using System;

namespace LineComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LineComp l1 = new LineComp(4,6,2,8);
            l1.CalculateLength();
        }
    }
}