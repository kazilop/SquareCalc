using System;


namespace CalcSquare
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;


        public Triangle(double aa, double bb, double cc) 
        {
            if (aa + bb > cc && aa + cc > bb && bb + cc > aa)
            {
                a = aa;
                b = bb;
                c = cc;
            }
            else
            {
                Console.WriteLine("Not triangle");
                throw new ArgumentOutOfRangeException("Not triangle");
            }
        }

        /// <summary>
        /// Return Square of triangle
        /// </summary>
        /// <returns>double volue </returns>
        public override double Square()
        {
            double PoluPerimetr = (a + b + c)/2;
            return Math.Sqrt(PoluPerimetr * (PoluPerimetr - a) *
                (PoluPerimetr - b) * (PoluPerimetr - c));
        }

        /// <summary>
        /// Check if it triangle is rectangular
        /// </summary>
        /// <returns>true or false </returns>
        public bool IsRectangular()
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                return true;
            return false;
        }
    }
}
