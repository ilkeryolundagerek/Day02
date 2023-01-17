using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            SomethingMeter meter = new SomethingMeter();
            Console.WriteLine(meter.Result);
            meter.Measure = 75;
            //Console.WriteLine(meter.Measure);

            Card spades_ace = new Card("Spades", "Ace");
            Card clubs_2 = new Card("Clubs", "2");

            Console.WriteLine(spades_ace);
            Console.WriteLine(clubs_2);

            Console.WriteLine(BaseEntity.GetActve());

            Person p = new Person();
            Department d = new Department();
            d.Title = "Test";
            d.Description = "Lorem ipsum";
            d.CreateDate = DateTime.Now;
            p.Title = "Mr.";
            p.Firstname = "İlker";
            p.Lastname = "Turan";
            p.CreateDate = DateTime.Now;
            p.MyDepartment = d;
            d.People.Add(p);
            */
            /*
            OC_ShapeCalculaterGood calculaterGood = new OC_ShapeCalculaterGood();
            OC_IShapeGood t1 = new OC_TriagleGood(5, 3, 4);
            OC_IShapeGood c1 = new OC_CircleGood(7);
            Console.WriteLine(calculaterGood.CalculatePerimeter(t1));
            Console.WriteLine(calculaterGood.CalculatePerimeter(c1));

            Employee e1 = new Employee();
            Employee e2 = new Employee();
            SalesPerson s1 = new SalesPerson();
            SalesPerson s2 = new SalesPerson();

            Person[] people = { e1, e2, s1, s2 };
            */

            DI_FrontEndDeveloperGood f1 = new DI_FrontEndDeveloperGood();
            DI_FrontEndDeveloperGood f2 = new DI_FrontEndDeveloperGood();
            DI_BackEndDeveloperGood b1 = new DI_BackEndDeveloperGood();
            DI_BackEndDeveloperGood b2 = new DI_BackEndDeveloperGood();
            DI_BackEndDeveloperGood b3 = new DI_BackEndDeveloperGood();

            DI_ProjectGood projectGood = new DI_ProjectGood();
            projectGood.Developers.Add(f1);
            projectGood.Developers.Add(f2);
            projectGood.Developers.Add(b1);
            projectGood.Developers.Add(b2);
            projectGood.Developers.Add(b3);

            projectGood.CreateProject();
        }
    }
}
