using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Sсhool : EducationTM
    {
        public Sсhool(int examEnter, int examAttestat):base(examEnter,examAttestat)
        {}

        protected override bool Enter(int exam)
        {
            if (exam > 0 && exam <= 10)
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
