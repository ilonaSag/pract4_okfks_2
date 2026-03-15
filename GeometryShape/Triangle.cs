using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
        public class Triangle : Shape
        {
            private double sideA;
            public double SideA
            {
                get { return sideA; }
                set { sideA = value; }
            }
            private double sideB;
            public double SideB
            {
                get { return sideB; }
                set { sideB = value; }
            }
            private double sideC;
            public double SideC
            {
                get { return sideC; }
                set { sideC = value; }
            }
            public Triangle(double sideA, double sideB, double sideC)
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;
            }
            public override double Area()
            {
            try
            {
                double p = Perimeter() / 2;
                if (SideA + SideC < SideB ||
                    SideA + SideB < SideC ||
                    SideB + SideC < SideA)
                {
                    throw new ArgumentException("Такого треугольника не существует");
                }
                else if (SideA <= 0 ||
                    SideB <= 0 ||
                    SideC <= 0)
                {
                    throw new ArgumentException("Стороны треугольника не могут быть меньше 0 или равны 0");
                }

                else
                    return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
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
                if (SideA + SideC < SideB ||
                    SideA + SideB < SideC ||
                    SideB + SideC < SideA)
                {
                    throw new ArgumentException("Такого треугольника не существует");
                }
                else if (SideA <= 0 ||
                    SideB <= 0 ||
                    SideC <= 0)
                {
                    throw new ArgumentException("Стороны треугольника не могут быть меньше 0 или равны 0");
                }
                else
                    return SideA + SideB + SideC;
            }
            catch
            {
                throw new ArgumentException("Неправильный ввод");
            }
        }
            public override string ToString()
            {
                return $"Стороны треугольника = {SideA}, {SideB}, {SideC}\nПлощадь = {Area()}, периметр = {Perimeter()}";
            }
        }
    }

