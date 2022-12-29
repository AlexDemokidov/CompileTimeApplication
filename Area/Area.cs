using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Area
{
    public class CalcArea
    {
        public static string OneParameter(double a)
        {
            Console.WriteLine("Area of the circle = " + Round(PI * a * a, 2));
            Console.WriteLine("Area of the square = " + Round(a * a, 2));
            string s = Convert.ToString(Round(PI * a * a, 2) + " " + Round(a * a, 2));
            return s;
        }
        public static string TwoParameter(double a, double b)
        {
            Console.WriteLine("Area of the rectangle = " + Round(a * b, 2));
            Console.WriteLine("Area of the right triangle = " + Round(a * b / 2, 2));
            string s = Convert.ToString(Round(a * b, 2) + " " + Round(a * b / 2, 2));
            return s;
        }
        public static string ThreeParameter(double firstSide, double secondSide, double thirdSide)
        {
            if ((firstSide > secondSide) & (firstSide > thirdSide))
            {
                if (firstSide * firstSide == secondSide * secondSide + thirdSide * thirdSide)
                    Console.WriteLine("Right triangle");
            }
            else if ((secondSide > firstSide) & (secondSide > thirdSide))
            {
                if (secondSide * secondSide == firstSide * firstSide + thirdSide * thirdSide)
                    Console.WriteLine("Right triangle");
            }
            else if ((thirdSide > firstSide) & (thirdSide > secondSide))
            {
                if (thirdSide * thirdSide == firstSide * firstSide + secondSide * secondSide)
                    Console.WriteLine("Right triangle");
            }
            double p = (firstSide + secondSide + thirdSide) / 2;
            double s = Round(Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide)), 2);
            Console.WriteLine("Area of the rectangle = " + s);
            return Convert.ToString(s);
        }
    }
}
