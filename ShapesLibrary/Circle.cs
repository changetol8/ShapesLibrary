namespace ShapesLibrary
{
    internal class Circle : Shape
    {
        private readonly double _radius;

        public required double Radius
        {
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius must be more than 0", nameof(value));
                }

                _radius = value;
            }
        }

        public override double CalculateArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
