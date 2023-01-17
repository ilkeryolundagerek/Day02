using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID
{
    public class InterfaceSegregation
    {
    }

    //Bad Way:

    interface IS_IWorkBad
    {
        void drive();
        void report();
        void produce();
        void manage();
        void record();
    }

    class IS_EmployeeBad : IS_IWorkBad
    {
        public void drive()
        {
            throw new NotImplementedException();
        }

        public void manage()
        {
            throw new NotImplementedException();
        }

        public void produce()
        {
            throw new NotImplementedException();
        }

        public void record()
        {
            throw new NotImplementedException();
        }

        public void report()
        {
            throw new NotImplementedException();
        }
    }

    //Good Way:
    interface IS_IDriverGood
    {
        void drive();
    }
    interface IS_IReportGood
    {
        void report();
    }
    interface IS_IProducerGood
    {
        void produce();
    }
    interface IS_IManagerGood
    {
        void manage();
    }
    interface IS_IRecorderGood
    {
        void record();
    }

    class IS_DriverGood : IS_IDriverGood, IS_IRecorderGood
    {
        public void drive()
        {
            throw new NotImplementedException();
        }

        public void record()
        {
            throw new NotImplementedException();
        }
    }

    class IS_ProduceManager : IS_IProducerGood, IS_IManagerGood, IS_IReportGood
    {
        public void manage()
        {
            throw new NotImplementedException();
        }

        public void produce()
        {
            throw new NotImplementedException();
        }

        public void report()
        {
            throw new NotImplementedException();
        }
    }

}
