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
        //[Fact]
        //public void Rectangle_StringReturnsCorrectFormat()
        //{
        //    double width = 5;
        //    double height = 10;
        //    Rectangle rectangle = new Rectangle(width, height);
        //    string expectedString = $"Ширина прямоугольника = {width}, высота = {height}\nПлощадь = {width * height}, периметр = {2 * (width + height)}";
        //    string actualString = rectangle.ToString();
        //    Assert.Equal(expectedString, actualString);
        //}

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
        /*ТЕСТЫ ДЛЯ ТРЕУГОЛЬНИКА*/

        //тест на рассчет площади
        [Fact]
        public void Triangle_Area()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6;
            double actualArea = triangle.Area();
            Assert.Equal(expectedArea, actualArea, 5);
        }

        //тест на рассчет периметра
        [Fact]
        public void Triangle_Perimeter()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedPerimeter = 12;
            double actualPerimeter = triangle.Perimeter();
            Assert.Equal(expectedPerimeter, actualPerimeter);
        }

        //Тест проверяет, что метод возвращает строку в правильном формате
        //[Fact]
        //public void Triangle_StringReturnsCorrectFormat()
        //{
        //    double sideA = 3;
        //    double sideB = 4;
        //    double sideC = 5;
        //    Triangle triangle = new Triangle(sideA, sideB, sideC);
        //    double p = (sideA + sideB + sideC) / 2;
        //    double area = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        //    string expectedString = $"Стороны треугольника = {sideA}, {sideB}, {sideC}\nПлощадь = {area}, периметр = {sideA + sideB + sideC}";
        //    string actualString = triangle.ToString();
        //    Assert.Equal(expectedString, actualString);
        //}

        //проверка выброса исключения если сумма двух сторон меньше третьей (вариант 1)
        [Fact]
        public void Triangle_InvalidSides1_Area()
        {
            double sideA = 1;
            double sideB = 2;
            double sideC = 10;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если сумма двух сторон меньше третьей (вариант 2)
        [Fact]
        public void Triangle_InvalidSides2_Area()
        {
            double sideA = 10;
            double sideB = 1;
            double sideC = 2;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если сумма двух сторон меньше третьей (вариант 3)
        [Fact]
        public void Triangle_Invalid3_Area()
        {
            double sideA = 2;
            double sideB = 10;
            double sideC = 1;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если сторона A меньше нуля
        [Fact]
        public void Triangle_SideALessThanZero_Area()
        {
            double sideA = 1;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если сторона B меньше нуля
        [Fact]
        public void Triangle_SideBLessThanZero_Area()
        {
            double sideA = 3;
            double sideB = -1;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если сторона C меньше нуля
        [Fact]
        public void Triangle_SideCLessThanZero_Area()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = -1;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если сторона A равна нулю
        [Fact]
        public void Triangle_SideAEqualToZero_Area()
        {
            double sideA = 0;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если сторона B равна нулю
        [Fact]
        public void Triangle_SideBEqualToZero_Area()
        {
            double sideA = 3;
            double sideB = 0;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если сторона C равна нулю
        [Fact]
        public void Triangle_SideCEqualToZero_Area()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если все стороны равны нулю
        [Fact]
        public void Triangle_AllSidesEqualToZero_Area()
        {
            double sideA = 0;
            double sideB = 0;
            double sideC = 0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если все стороны меньше нуля
        [Fact]
        public void Triangle_AllSidesLessThanZero_Area()
        {
            double sideA = -1;
            double sideB = -2;
            double sideC = -3;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если две стороны меньше нуля
        [Fact]
        public void Triangle_TwoSidesLessThanZero_Area()
        {
            double sideA = -1;
            double sideB = -2;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если одна сторона отрицательная, другая нулевая
        [Fact]
        public void Triangle_MixedInvalidValues_Area()
        {
            double sideA = -1;
            double sideB = 0;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Area());
        }

        //проверка выброса исключения если сумма двух сторон меньше третьей (вариант 1)
        [Fact]
        public void Triangle_InvalidSides1_Perimeter()
        {
            double sideA = 1;
            double sideB = 2;
            double sideC = 10;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если сумма двух сторон меньше третьей (вариант 2)
        [Fact]
        public void Triangle_InvalidSides2_Perimeter()
        {
            double sideA = 10;
            double sideB = 1;
            double sideC = 2;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если сумма двух сторон меньше третьей (вариант 3)
        [Fact]
        public void Triangle_InvalidSides3_Perimeter()
        {
            double sideA = 2;
            double sideB = 10;
            double sideC = 1;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если сторона A меньше нуля
        [Fact]
        public void Triangle_SideALessThanZero_Perimeter()
        {
            double sideA = -1;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если сторона B меньше нуля
        [Fact]
        public void Triangle_SideBLessThanZero_Perimeter()
        {
            double sideA = 3;
            double sideB = -1;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если сторона C меньше нуля
        [Fact]
        public void Triangle_SideCLessThanZero_Perimeter()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = -1;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если сторона A равна нулю
        [Fact]
        public void Triangle_SideAEqualToZero_Perimeter()
        {
            double sideA = 0;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если сторона B равна нулю
        [Fact]
        public void Triangle_SideBEqualToZero_Perimeter()
        {
            double sideA = 3;
            double sideB = 0;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если сторона C равна нулю
        [Fact]
        public void Triangle_SideCEqualToZero_Perimeter()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если все стороны равны нулю
        [Fact]
        public void Triangle_AllSidesEqualToZero_Perimeter()
        {
            double sideA = 0;
            double sideB = 0;
            double sideC = 0;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если все стороны меньше нуля
        [Fact]
        public void Triangle_AllSidesLessThanZero_Perimeter()
        {
            double sideA = -1;
            double sideB = -2;
            double sideC = -3;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если две стороны меньше нуля
        [Fact]
        public void Triangle_TwoSidesLessThanZero_Perimeter()
        {
            double sideA = -1;
            double sideB = -2;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }

        //проверка выброса исключения если одна сторона отрицательная, другая нулевая
        [Fact]
        public void Triangle_MixedInvalidValues_Perimeter()
        {
            double sideA = -1;
            double sideB = 0;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.Throws<ArgumentException>(() => triangle.Perimeter());
        }
    } 
} 
