using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Four
{
    internal class Square : IFigure
    {
        private double _sideLength;

        public Square(double sideLength)
        { 
            _sideLength = sideLength;
        }

        public double GetPerimeter()
        {
            return 4 * _sideLength;
        }

        public double GetSquare()
        {
           return _sideLength * _sideLength;
        }
    }
}
