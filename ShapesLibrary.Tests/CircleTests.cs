namespace ShapesLibrary.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(5, Math.PI * 25)]
        [InlineData(10, Math.PI * 100)]
        [InlineData(2.5, Math.PI * 6.25)]
        public void Circle_CalculateArea_ReturnsCorrectArea(double radius, double expectedArea)
        {
            // Arrange
            Circle circle = new() { Radius = radius };

            // Act
            double area = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, area);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-1.4)]
        public void Circle_Constructor_ThrowsArgumentExceptionIfRadiusLessOrZero(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle() { Radius = radius });
        }
    }
}
