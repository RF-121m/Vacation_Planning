using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My3Refactoring

{
    public class TimeSheet
    {//...
        public double Charge(Employee employee, int days)
        {
            double baseAmount = employee.Rate * days;

            if (employee.HasSpecialSkill)
            {
                return baseAmount * 1.05;
            }
            else
                return baseAmount;
        }
    }


    public class Employee
    {//...
        public int Rate
        {
            get;
            private set;
        }
        //..
        public bool HasSpecialSkill { get; }
    }


        static void Main(string[] args)
        {
        }
    }
}
