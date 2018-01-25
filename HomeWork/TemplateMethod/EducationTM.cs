using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class EducationTM
    {
        private int _examEnter;
        private int _examAttestat;

        public EducationTM(int examEnter, int examAttestat)
        {
            _examEnter = examEnter;
            _examAttestat = examAttestat;
        }

        protected abstract bool Enter(int exam);

        public void Study()
        {
            if(Enter(_examEnter))
                Console.WriteLine("You study.");
            else
                Console.WriteLine("You don't study.");
        }
        protected abstract bool PassExams(int exam);

        public void GetAttestat()
        {
            if (PassExams(_examAttestat) && Enter(_examEnter))
                Console.WriteLine("You completed.");
            else
                Console.WriteLine("You didn't complete.");
        }
    }
}
