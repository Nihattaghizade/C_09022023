using System;
using System.Collections.Generic;
using System.Text;

namespace _09022023hometask
{
    internal class Engineer:Employee
    {

        public virtual double _salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 1000) ;
            }
        }
    }
}
