using Xunit; 
using GeometryShape; 
 
namespace GeometryShape.Tests 
{ 
    public class UnitTest1 
    {
        /*ТЕСТЫ ДЛЯ ПРЯМОУГОЛЬНИКА*/

        //тест на рассчет площади
        [Fact]
        public void Rectangle_Area()
        {
            double width = 5;
            double height = 10;
            Rectangle rectangle = new Rectangle(width, height);
            double expectedArea = 50;
            double actualArea = rectangle.Area();
            Assert.Equal(expectedArea, actualArea);
        }
        //тест на рассчет периметра
        [Fact]
        public void Rectangle_Perimeter()
        {
            double width = 5;
            double height = 10;
            Rectangle rectangle = new Rectangle(width, height);
            double expectedPerimeter = 30;
            double actualPerimeter = rectangle.Perimeter();
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }
        //Тест проверяет, что метод возвращает строку в правильном формате с корректными значениями ширины, высоты, площади и периметра
        [Fact]
        public void Rectangle_StringReturnsCorrectFormat()
        {
            double width = 5;
            double height = 10;
            Rectangle rectangle = new Rectangle(width, height);
            string expectedString = $"Ширина прямоугольника = {width}, высота = {height}\nПлощадь = {width * height}, периметр = {2 * (width + height)}";
            string actualString = rectangle.ToString();
            Assert.Equal(expectedString, actualString);
        }

        //проверка выброса исключения если ширина и высота равны
        [Fact]
        public void Rectangle_WidthAndHeightAreEqual_Area()
        {
            double width = 5;
            double height = 5;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Area());
        }
        //проверка выброса исключения если ширина меньше нуля
        [Fact]
        public void Rectangle_WidthLessThanZero_Area()
        {
            double width = -1;
            double height = 5;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Area());
        }
        //проверка выброса исключения если ширина равна нулю
        [Fact]
        public void Rectangle_WidthEqualToZero_Area()
        {
            double width = 0;
            double height = 5;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Area());
        }
        //проверка выброса исключения если высота меньше нуля
        [Fact]
        public void Rectangle_HeightLessThanZero_Area()
        {
            double width = 5;
            double height = -1;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Area());
        }
        //проверка выброса исключения если высота равна нулю
        [Fact]
        public void Rectangle_HeightEqualToZero_Area()
        {
            double width = 5;
            double height = 0;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Area());
        }
        //проверка выброса исключения если высота и ширина равна нулю
        [Fact]
        public void Rectangle_HeightAndWidthEqualToZero_Area()
        {
            double width = 0;
            double height = 0;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Area());
        }
        //проверка выброса исключения если высота и ширина меньше нуля
        [Fact]
        public void Rectangle_WidthAndHeightLessThanZero_Area()
        {
            double width = -1;
            double height = -1;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Area());
        }
        //проверка выброса исключения если ширина и высота равны
        [Fact]
        public void Rectangle_WidthAndHeightAreEqual_Perimeter()
        {
            double width = 5;
            double height = 5;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Perimeter());
        }
        //проверка выброса исключения если ширина меньше нуля
        [Fact]
        public void Rectangle_WidthLessThanZero_Perimeter()
        {
            double width = -1;
            double height = 5;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Perimeter());
        }
        //проверка выброса исключения если ширина равна нулю
        [Fact]
        public void Rectangle_WidthEqualToZero_Perimeter()
        {
            double width = 0;
            double height = 5;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Perimeter());
        }
        //проверка выброса исключения если высота меньше нуля
        [Fact]
        public void Rectangle_HeightLessThanZero_Perimeter()
        {
            double width = 5;
            double height = -1;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Perimeter());
        }
        //проверка выброса исключения если высота равна нулю
        [Fact]
        public void Rectangle_HeightEqualToZero_Perimeter()
        {
            double width = 5;
            double height = 0;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Perimeter());
        }
        //проверка выброса исключения если высота и ширина равна нулю
        [Fact]
        public void Rectangle_HeightAndWidthEqualToZero_Perimeter()
        {
            double width = 0;
            double height = 0;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Perimeter());
        }
        //проверка выброса исключения если высота и ширина меньше нуля
        [Fact]
        public void Rectangle_WidthAndHeightLessThanZero_Perimeter()
        {
            double width = -1;
            double height = -1;
            Rectangle rectangle = new Rectangle(width, height);
            Assert.Throws<ArgumentException>(() => rectangle.Perimeter());
        }
    } 
} 
