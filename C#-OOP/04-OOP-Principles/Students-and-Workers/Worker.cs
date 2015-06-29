using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_Workers
{
    public class Worker:Human
    {
        private int salary;
        private int workHoursPerDay;
        private const int MIN_SALARY = 150;
        private const int MAX_WORKING_HOURS = 8;

        public Worker(string fname, string lname, int salary, int hours)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Salary = salary;
            this.WorkHoursPerDay = hours;
            
        }

        public int WorkHoursPerDay 
        {
            get { return this.workHoursPerDay;}
            set
            {
                if (IsValidWorkHours(value))
                {
                    this.workHoursPerDay = value;
                }
                else
                {
                    throw new ArgumentException("The hours should be in the range 0-8");
                }
            }
        }

        public int Salary
        {
            get { return this.salary; }
            set
            {
                if (IsValidSalary(value))
                {
                    this.salary = value;
                }
                else
                {
                    throw new ArgumentException("The salary should be more than 150 BGN");
                }
            }
        }

        public double MoneyPerHour()
        {
            return this.salary / this.workHoursPerDay;
        }

        private bool IsValidSalary( int salary)
        {
            if(salary >= MIN_SALARY)
            {
                return true;
            }
            return false;
        }

        private bool IsValidWorkHours(int hours)
        {
            if (hours <= MAX_WORKING_HOURS && hours > 0)
            {
                return true;
            }
            return false;
        }

    }
}
