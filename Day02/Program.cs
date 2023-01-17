using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinif sinif = new Sinif();
        }
    }
    public enum Aylar { Ocak, Subat }

    //Arabirim: Manifesto olarak kullanılabilirler. Bir sınıfın kullanmasını zorunlu kıldığımız metot ve property yapılarını tanımlarız.
    public interface Arabirim
    {
        int Oku();
        void Yaz(int deger);
    }

    public class Sinif : Arabirim
    {
        private int mulk1;
        protected string _mulk2;
        public bool Mulk3;

        public int Oku()
        {
            return mulk1;
        }

        public void Yaz(int deger)
        {
            mulk1 = deger;
        }
    }
}
