using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class University : EducationTM
    {
        public string Name { get; set; }
        public University(int examEnter, int examAttestat, string name) : base(examEnter, examAttestat)
        {
            Name = name;
        }
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
