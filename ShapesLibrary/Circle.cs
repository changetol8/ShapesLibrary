namespace ShapesLibrary
{
    public class Circle : Shape
    {
        private readonly double _radius;

        public required double Radius
        {
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Радиус должен быть больше нуля", nameof(value));
                }

                _radius = value;
            }
        }

        public override double CalculateArea()
        {
            var area = Math.PI * _radius * _radius;

            return area;
        }
    }
}
