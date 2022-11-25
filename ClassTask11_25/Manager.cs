using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11_25
{
    internal class Manager
    {
        private protected Employee GetPromotion(Employee employee)
        {
            employee.Salary += 100;
            return employee;
        }
    }
}
