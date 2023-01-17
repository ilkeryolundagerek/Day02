using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    //Soyutlanmış sınıflar (abstract): Bu tip sınıflar sadece kalıtım alınabilen, örneklenemeyen sınıflardır. Bu durum bir sınıfı sanki interfacemiş gibi kullanmamızı da sağlar.
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }

        public static bool GetActve()
        {
            return true;
        }
    }

    public class Person : BaseEntity
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
    }

    public class Employee : Person
    {
        public Department MyDepartment { get; set; }
    }

    public class SalesPerson : Person
    {
        public double Quota { get; set; }

    }

    public class Department : BaseEntity
    {
        public List<Person> People { get; set; }
        public Department()
        {
            People = new List<Person>();
        }
    }
}
