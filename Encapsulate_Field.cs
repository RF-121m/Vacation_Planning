using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondRef
{
    public class TimeSheet
    {//...
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Charge(IBillable employee, int days)
        {
            double baseAmount = employee.Rate * days;

            if (employee.HasSpecialSkill())
            {
                return baseAmount * 1.05;
            }
            else
                return baseAmount;
        }
    }
    public interface IBillable
    {
        int Rate { get; }
        bool HasSpecialSkill();

    }

    public class Employee : IBillable
    {//...
        public int Rate
        {
            get;
            private set;
        }
        //..
        public bool HasSpecialSkill { get; }

        int IBillable.Rate
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        bool IBillable.HasSpecialSkill()
        {
            throw new NotImplementedException();
        }
    }




}
