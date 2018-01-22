using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryStudent : IFactoryStudent
    {
        public IStudent CreateStudent(int rating, string country)
        {
            if (!country.Equals("Belarus"))
                return new ForeignStudent();
            else
            {
                if (rating <= 10 && rating > 8)
                    return new BestStudent();
                else if (rating <= 8 && rating > 4)
                {
                    return new AverageStudent();
                }
                else if (rating <= 4 && rating > 0)
                    return new BadStudent();
            }
            throw new ArgumentException("Неверные данные!");
        }
    }
}
