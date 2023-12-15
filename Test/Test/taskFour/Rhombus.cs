using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Four
{
    internal class Rhombus : IFigure
    {
        private double _firstDiagonal;
        private double _secondDiagonal;
        private double _sideLength;

        public Rhombus(double firstDiagonal, double secondDiagonal, double sideLength)
        {
            _firstDiagonal = firstDiagonal;
            _secondDiagonal = secondDiagonal;
            _sideLength = sideLength;
        }

        public double GetPerimeter()
        {
            return 4 * _sideLength;
        }

        public double GetSquare()
        {
            return _secondDiagonal * _firstDiagonal / 2;
        }
      
    }
}
