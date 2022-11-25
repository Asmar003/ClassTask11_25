using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11_25
{
    internal class Assistant:Manager
    {
        public void GetFeedBack(Employee employee, Assistant assistant)
        {
            if(employee.IsSuccesful==true)
            {
                Console.WriteLine("is succeful");
                GetPromotion(employee);
            }
            else
            {
                if (employee.IsSuccesful == false)
                {
                    Console.WriteLine("is not succesful");
                }
            }

        }
    }
}
