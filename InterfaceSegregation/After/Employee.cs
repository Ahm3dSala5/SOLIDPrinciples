using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation.After
{
    public abstract class Employee
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public decimal Salary { set; get; }
        public abstract string PrintSalarySlip();
        protected abstract decimal CalculateNetSalary();
    }
}
