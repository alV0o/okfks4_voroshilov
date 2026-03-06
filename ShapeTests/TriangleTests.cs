using okfks4_voroshilov;

namespace ShapeTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0,5,10)]
        [InlineData(5, 0, 10)]
        [InlineData(5,10,0)]
        [InlineData(5,10,5)]
        [InlineData(10,5,5)]
        [InlineData(5,5,10)]
        public void CreateTriangle_BadResult(double sideA, double sideB, double sideC)
        {
            Triangle triangle;
            Assert.Throws<Exception>(() => triangle = new Triangle(sideA,sideB,sideC));
        }

        [Theory]
        [InlineData(2,4.1,5)]
        [InlineData(4,5,5.2)]
        [InlineData(6.5,5,7)]
        public void AreaTests_CorrectResult(double sideA, double sideB,double sideC)
        {
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double p = (sideA + sideB + sideC) / 2;
            double S = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            double expected = S;
            Assert.Equal(expected, triangle.Area());
        }

        [Theory]
        [InlineData(2, 4.1, 5)]
        [InlineData(4, 5, 5.2)]
        [InlineData(6.5, 5, 7)]
        public void PerimeterTests_CorrectResult(double sideA, double sideB,double sideC)
        {
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expected = sideA + sideB + sideC;
            Assert.Equal(expected, triangle.Perimeter());
        }

        [Fact]
        public void BadPerimeterTest_IncorrectResult()
        {
            var triangle = new Triangle(5, 6, 7);
            double expected = 5 + 6 + 7 + 1;
            Assert.Equal(expected, triangle.Perimeter());
        }
    }
}
