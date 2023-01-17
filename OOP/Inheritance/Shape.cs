using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public interface IShape
    {
        double CalculatePerimeter();
    }
    public class Shape : IShape
    {
        public string Name { get; set; }

        public Shape()
        {
            Name = "Shape";
        }

        //virtual: İlgili mülkü soyutlaştırarak kalıtım alan sınıfların bu yapıyı yeniden yazması (override) mümkün olur.
        public virtual double CalculatePerimeter()
        {
            return 0;
        }
    }

    public class Rectangle : Shape
    {
        protected double _a;
        protected double _b;

        public Rectangle(double a, double b)
        {
            this._a = a;
            this._b = b;
            Name = "Rectangle";
        }

        public override double CalculatePerimeter()
        {
            return 2 * (_a + _b);
        }
    }

    public class Square : Rectangle
    {
        //base: Parent sınıfa giderek oradaki metotları kullanmamızı sağlar. Buradaki örnekte yapıcı metodu tektikler.
        public Square(double a) : base(a, a)
        {
            Name = "Square";
        }
    }

    public class Circle : Shape
    {
        private double r;
        private double pi;

        public Circle(double r, double pi = Math.PI)
        {
            this.r = r;
            this.pi = pi;
        }

        public override double CalculatePerimeter()
        {
            return 2 * r * pi;
        }
    }
}
