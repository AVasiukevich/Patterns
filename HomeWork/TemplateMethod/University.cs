using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class University : EducationTM
    {
        public University(int examEnter, int examAttestat):base(examEnter,examAttestat)
        { }

        protected override bool Enter(int exam)
        {
            if (exam > 6 && exam <= 10)
                return true;

            return false;
        }

        protected override bool PassExams(int exam)
        {
            if (exam > 4 && exam <= 10)
                return true;

            return false;
        }
    }
}
