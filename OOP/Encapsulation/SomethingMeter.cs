using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class SomethingMeter
    {
        private double measure;
        //Sadece yazılabiliir yapı için sadece set yazılamaz, get işlemini private olarak tanımlarız.
        public double Measure
        {
            private get { return measure; }
            set
            {
                //set içine özellikle private karşılığı yazılmazsa public property ayrı olarak adreslenir.
                measure = value < 0 || value > 100 ? 0 : value;
            }
        }

        public string Result
        {
            get
            {
                return measure > 50 ? "Oh my!!!" : "What ever!!!";
            }
        }
    }
}
