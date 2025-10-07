using System.Reflection.Metadata.Ecma335;

namespace InterfaceSegregation.Before
{
    public class Consultant : Employee , IEntitlement
    {
        public decimal CalculateBounses() => Salary * 0.5m;

        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension() =>
            throw new NotSupportedException("Consultent Not Has Pension");

        public decimal CalculateRentalSubsidy() =>
        throw new NotSupportedException("Consultent Not Has Rental Subsidy");

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
