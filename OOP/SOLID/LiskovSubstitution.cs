using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID
{
    public class LiskovSubstitution
    {
    }

    class LS_RectangleBad
    {
        public double A;
        public double B;

        public LS_RectangleBad(double a, double b)
        {
            A = a;
            B = b;
        }

        public double CalculateArea()
        {
            return A * B;
        }
    }

    class LS_SqareBad : LS_RectangleBad
    {
        public LS_SqareBad(double a) : base(a, a)
        {
        }
    }

    //Good Way:
    class LS_RectangleGood
    {
        public double A;
        public double B;
        public bool IsSquare { get { return A == B; } }

        public LS_RectangleGood(double a, double b)
        {
            A = a;
            B = b;
        }

        public double CalculateArea()
        {
            return A * B;
        }
    }
}
