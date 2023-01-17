using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID
{
    public class DependencyInversion
    {
    }

    //Bad Way:
    class DI_FrontEndDeveloperBad
    {
        public void WriteHtml() { }

        public void WriteXml() { }
    }

    class DI_BackEndDeveloperBad
    {
        public void WriteTypescript() { }
        public void WriteJava() { }
        public void WriteCSharp() { }
    }

    class DI_ProjectBad
    {
        public DI_FrontEndDeveloperBad frontEndDeveloperBad;
        public DI_BackEndDeveloperBad backEndDeveloperBad;

        public DI_ProjectBad()
        {
            frontEndDeveloperBad = new DI_FrontEndDeveloperBad();
            backEndDeveloperBad = new DI_BackEndDeveloperBad();
        }

        public void CreateProject()
        {
            frontEndDeveloperBad.WriteHtml();
            backEndDeveloperBad.WriteTypescript();
        }
    }

    //Good Way:

    interface DI_IDeveloperGood
    {
        void Develop();
    }

    class DI_FrontEndDeveloperGood:DI_IDeveloperGood
    {
        public void Develop()
        {
            WriteHtml();
        }

        public void WriteHtml() { }

        public void WriteXml() { }
    }

    class DI_BackEndDeveloperGood: DI_IDeveloperGood
    {
        public void WriteTypescript() { }
        public void WriteJava() { }
        public void WriteCSharp() { }

        public void Develop()
        {
            WriteTypescript();
        }
    }

    class DI_ProjectGood
    {
        public List<DI_IDeveloperGood> Developers;
        public DI_ProjectGood()
        {
            Developers = new List<DI_IDeveloperGood>();
        }
        public void CreateProject()
        {
            foreach (var developer in Developers)
            {
                developer.Develop();
            }
        }
    }

}
