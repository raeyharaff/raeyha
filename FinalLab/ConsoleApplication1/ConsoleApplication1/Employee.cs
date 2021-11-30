using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public abstract class Employee : SalaryEmployee
    {
        public int EmployeeID
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public char EmployeeName
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int EmployeeType
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int Hours
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int NoOfUnit
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void calculateSalary()
        {
            throw new System.NotImplementedException();
        }
    }
}