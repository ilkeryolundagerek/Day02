using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    //T: Baskın tip olarak yazıldı, where T: class ise bu tipin sınıf tanımlaması olacağını belirtir.
    public interface IRepository<T> where T : class
    {
        //CRUD (Create, Read, Update, Delete) İşlemleri:
        bool Create(T entity);
        T Read(object id);
        List<T> ReadAll();
        bool Update(T entity, object id);
        bool Delete(object id);
    }

    public abstract class Repository<T> : IRepository<T> where T : class
    {
        public virtual bool Create(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public virtual T Read(object id)
        {
            throw new NotImplementedException();
        }

        public virtual List<T> ReadAll()
        {
            throw new NotImplementedException();
        }

        public virtual bool Update(T entity, object id)
        {
            throw new NotImplementedException();
        }
    }

    public class PersonRepository : Repository<Person>
    {
        public override bool Delete(object id)
        {
            return base.Delete(id);
        }

        public override Person Read(object id)
        {
            return base.Read(id);
        }

        public Person FindFirst(string[] search_args)
        {
            throw new NotImplementedException();
        }
    }
}
