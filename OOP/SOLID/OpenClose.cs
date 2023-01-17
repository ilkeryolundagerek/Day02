using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID
{
    public class OpenClose
    {
    }

    //Bad Way:
    class OC_TriangleBad
    {
        public double A;
        public double B;
        public double C;

        public OC_TriangleBad(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }

    class OC_CircleBad
    {
        public double r;
        public double PI;

        public OC_CircleBad(double r, double pi = Math.PI)
        {
            this.r = r;
            PI = pi;
        }
    }

    class OC_ShapeCalculaterBad
    {
        public double CalculateTrianglePerimeter(OC_TriangleBad triangleBad)
        {
            return triangleBad.A + triangleBad.B + triangleBad.C;
        }

        public double CalculateCirclePerimeter(OC_CircleBad circleBad)
        {
            return circleBad.r * 2 * circleBad.PI;
        }
    }

    //Good Way:
    interface OC_IShapeGood
    {
        double CalculatePerimeter();
    }

    class OC_TriagleGood : OC_IShapeGood
    {
        public double A;
        public double B;
        public double C;

        public OC_TriagleGood(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalculatePerimeter()
        {
            return A + B + C;
        }
    }

    class OC_CircleGood : OC_IShapeGood
    {
        public double r;
        public double PI;

        public OC_CircleGood(double r, double pi = Math.PI)
        {
            this.r = r;
            PI = pi;
        }

        public double CalculatePerimeter()
        {
            return 2 * r * PI;
        }
    }

    class OC_ShapeCalculaterGood
    {
        public double CalculatePerimeter(OC_IShapeGood shapeGood)
        {
            return shapeGood.CalculatePerimeter();
        }
    }
}
