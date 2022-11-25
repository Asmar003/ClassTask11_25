using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask11_25
{
    internal class Employee
    {
        string _name;
        bool _isSuccesful;
        float _salary;

        public Employee()
        {
            Name = _name;
            Salary = _salary;
            
            
        }

        public string Name
        {
            get { return _name; }
            set
            {
                value.Trim();
                if(value.Length>2 && value.Length < 16)
                {
                    _name = value;
                }
            }
        }
        public bool IsSuccesful
        {
            get { return _isSuccesful; }
            set
            {
                _isSuccesful = value;
            }
        }
        public float Salary
        {
            get { return _salary; }
            set
            {
                if (value >=200)
                {
                    _salary = value;
                }
            }
        }
    }
}
