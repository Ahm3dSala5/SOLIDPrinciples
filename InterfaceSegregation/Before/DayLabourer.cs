namespace InterfaceSegregation.Before
{
    public class DayLabourer : Employee, IEntitlement
    {
        public decimal CalculateBounses() =>
            throw new NotSupportedException("DayLabourer Not Has Bouneses");


        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension()=>
            throw new NotSupportedException("DayLabourer Not Has Pension");

        public decimal CalculateRentalSubsidy()=>
        throw new NotSupportedException("DayLabourer Not Has Rental Subsidy");

        public decimal CalculateTransportation() => 150m;

        protected override decimal CalculateNetSalary()
        {
           return Salary +
                CalculateHealthInsurance() +
                CalculateTransportation();
        }

        public override string PrintSalarySlip()
        {
           return $"Day Labourer Employee Info\n" +
                "Id: {Id}, Name: {Name}, Salary: {Salary}, \n" +
                $"Health Insurance: {CalculateHealthInsurance()}, \n" +
                $"Transportation: {CalculateTransportation()}, \n" +
                $"Net Salary: {CalculateNetSalary()}\n";
        }
    }
}
