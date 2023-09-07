namespace ShapesLibrary.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(6, 8, 10, 24)]
        [InlineData(7, 7, 7, 21.2176)]
        public void Triangle_CalculateArea_ReturnsCorrectArea(double side1, double side2, double side3, double expectedArea)
        {
            // Arrange
            var triangle = new Triangle(side1, side2, side3);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, area, 4);
        }

        [Theory]
        [InlineData(1, 1, 10)]
        [InlineData(0, 0, 0)]
        [InlineData(7, 0, 7)]
        [InlineData(10, 1, 20)]
        public void Triangle_Constructor_ThrowsIfSidesInvalid(double side1, double side2, double side3)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }


        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(6, 8, 10, true)]
        [InlineData(7, 7, 7, false)]
        public void Triangle_IsRightTriangle_ReturnsCorrectResult(double side1, double side2, double side3, bool expectedResult)
        {
            // Arrange
            var triangle = new Triangle(side1, side2, side3);

            // Act
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.Equal(expectedResult, isRightTriangle);
        }
    }
}
