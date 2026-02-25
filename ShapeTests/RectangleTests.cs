using okfks4_voroshilov;
namespace ShapeTests
{
    public class RectangleTests
    {
        [Fact]
        public void CreateRectangle_ResultWidth()
        {
            var rectangle = new Rectangle(10,20);
            double expected = 10;
            Assert.Equal(expected, rectangle.Width);
        }

        [Fact]
        public void CreateRectangle_ResultHeight()
        {
            var rectangle = new Rectangle(10,20);
            double expected = 20;
            Assert.Equal(expected, rectangle.Height);
        }

        [Theory]
        [InlineData(0,20)]
        [InlineData(10,0)]
        [InlineData(-1,20)]
        [InlineData(10,-1)]
        [InlineData(0,0)]
        public void Rectangle_ResultException(double width, double height)
        {
            Rectangle rectangle;
            Assert.Throws<Exception>(() => rectangle = new Rectangle(width, height));
        }

        [Theory]
        [InlineData(10,20)]
        [InlineData(1,1)]
        [InlineData(2,2)]
        public void AreaRectangle_ResultArea(double width, double height)
        {
            var rectangle = new Rectangle(width, height);
            double expected = width*height;
            Assert.Equal(expected, rectangle.Area());
        }

        [Theory]
        [InlineData(10,20)]
        [InlineData(1,1)]
        [InlineData(2,2)]
        public void PerimeterRectangle_ResultPerimeter(double width, double height)
        {
            var rectangle = new Rectangle(width, height);
            double expected = width*2+height*2;
            Assert.Equal(expected, rectangle.Perimeter());
        }
    }
}