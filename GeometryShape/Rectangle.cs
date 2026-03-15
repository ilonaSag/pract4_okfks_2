using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            try
            {
                if (Width == Height)
                    throw new ArgumentException("Ширина и высота не должны быть равны");
                else if (Width <= 0 || Height <= 0)
                    throw new ArgumentException("Высота или ширина не могут быть равны или быть меньше 0");
                else
                    return Width * Height;
            }
            catch
            {
                throw new ArgumentException("Неправильный ввод");
            }
        }
        public override double Perimeter()
        {
            try
            {
                if (Width == Height)
                    throw new ArgumentException("Ширина и высота не должны быть равны");
                else if (Width <= 0 || Height <= 0)
                    throw new ArgumentException("Высота или ширина не могут быть равны или быть меньше 0");
                else
                    return 2 * (Width + Height);
            }
            catch
            {
                throw new ArgumentException("Неправильный ввод");
            }
        }
        public override string ToString()
        {
            return $"Ширина прямоугольника = {Width}, высота = {Height}\nПлощадь = {Area()}, периметр = {Perimeter()}";
        }
    }
}
