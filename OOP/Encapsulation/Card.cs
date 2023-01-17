using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    public class Card
    {
        private string face;
        //Readonly kapsülleme. Sadece private face değerini okuruz.
        public string Face
        {
            get
            {
                return face;
            }
        }

        private string value;
        public string Value
        {
            get
            {
                return value;
            }
        }

        //Soyut bir cevap aldığımız sadece okunabilir bir property.
        public int Point
        {
            get
            {
                switch (value)
                {
                    case "Ace":
                    case "Jack": return 1;
                    case "2" when face == "Clubs": return 2;
                    case "10" when face == "Diamonds": return 3;
                    default: return 0;
                }
            }
        }

        //Face yapısının get modelidir.
        public string getFace()
        {
            return face;
        }

        public Card(string face, string value)
        {
            this.face = face;
            this.value = value;
        }

        public override string ToString()
        {
            return $"{value} of {face} ({Point})";
        }
    }
}
