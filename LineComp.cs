using System;

namespace LineComparison
{
    public class LineComp
    {
        int firstX, firstY, secondX, secondY;

        public LineComp(int x1, int x2, int y1, int y2)
        {

            this.firstX = x1;
            this.firstY = y1;
            this.secondX = x2;
            this.secondY = y2;
        }

        public void CalculateLength()
        {

            double len = Math.Sqrt(Math.Pow(this.secondX - this.firstX,2) + Math.Pow(this.secondY - this.firstY,2));
            Console.WriteLine(len);
        }
    }
}