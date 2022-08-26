using System;


namespace CalcSquare
{
    public class Circle: Figure
    {
        private double _radius;


        public Circle(double radius)
        {
            if(radius > 0)
            {
                this._radius = radius;
            }
            else
            {
                Console.WriteLine("Not correct radius");
                throw new ArgumentOutOfRangeException("Not correct radius");
            }
        }
 

        /// <summary>
        /// Return Square of Circle
        /// </summary>
        /// <returns> double </returns>
        public override double Square()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
