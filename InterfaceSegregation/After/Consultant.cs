using System.Reflection.Metadata.Ecma335;

namespace InterfaceSegregation.After
{
    public class Consultant : Employee , IBounsesEntitlement, IHealthInsuranceEntitlement, ITransportationEntitlement
    {
        public decimal CalculateBounses() => Salary * 0.5m;

        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculateTransportation() => 150m;

        protected override decimal CalculateNetSalary()
        {
            return Salary +
                CalculateBounses()+
                CalculateHealthInsurance()+
                CalculateTransportation();
        }

        public override string PrintSalarySlip()
        {
            return $"Consultant Employee Info\n"+
                "Id: {Id}, Name: {Name}, Salary: {Salary}, \n" +
                $"Bounses: {CalculateBounses()}, \n" +
                $"Health Insurance: {CalculateHealthInsurance()}, \n" +
                $"Transportation: {CalculateTransportation()}, \n" +
                $"Net Salary: {CalculateNetSalary()}\n";
        }
    }
}
