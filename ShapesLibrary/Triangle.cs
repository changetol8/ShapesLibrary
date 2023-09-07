namespace ShapesLibrary
{
    public class Triangle : Shape
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (!IsValidSides(side1, side2, side3))
            {
                throw new ArgumentException("Стороны должны быть больше нуля и соблюдать формулу неравенства треугольника");
            }

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        private bool IsValidSides(double side1, double side2, double side3)
        {
            if (side1 <= 0 ||
                side2 <= 0 ||
                side3 <= 0)
            {
                return false;
            }

            // Формула неравенства треугольника
            return (side1 + side2) > side3 &&
                   (side1 + side3) > side2 &&
                   (side2 + side3) > side1;
        }

        public override double CalculateArea()
        {
            var semiperimeter = (_side1 + _side2 + _side3) / 2.0;

            // площадь по формуле Герона
            var area = Math.Sqrt(semiperimeter * (semiperimeter - _side1) *
                                                 (semiperimeter - _side2) *
                                                 (semiperimeter - _side3));

            return area;
        }

        public bool IsRightTriangle()
        {
            var sides = new List<double>() { _side1, _side2, _side3 };
            sides.Sort();

            // Проверка по теореме Пифагора
            return (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)) == Math.Pow(sides[2], 2);
        }
    }
}
