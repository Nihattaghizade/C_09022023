using System;
using System.Collections.Generic;
using System.Text;

namespace _09022023hometask
{
    internal class Employee
    {

        public string FullName;
        public double _salary;

        public virtual double salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 300) ;
            }
        }
    }
}
