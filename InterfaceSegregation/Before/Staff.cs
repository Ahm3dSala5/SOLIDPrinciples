namespace InterfaceSegregation.Before
{
    public class Staff : Employee , IEntitlement
    {
        public decimal CalculateBounses() => Salary * 0.05m;

        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension() => Salary * 2.5m;

        public decimal CalculateRentalSubsidy() => 150m;

        public decimal CalculateTransportation()=>
           throw new NotSupportedException("Staff Not Has Transportation");

        protected override decimal CalculateNetSalary()
        {
            return Salary +
                CalculateBounses() +
                CalculateHealthInsurance() +
                CalculatePension() +
                CalculateRentalSubsidy();
        }

        public override string PrintSalarySlip()
        {
            return $"Staff Employee Info\n" +
                "Id: {Id}, Name: {Name}, Salary: {Salary}, \n" +
                $"Bounses: {CalculateBounses()}, \n" +
                $"Health Insurance: {CalculateHealthInsurance()}, \n" +
                $"Pension: {CalculatePension()}, \n" +
                $"Rental Subsidy: {CalculateRentalSubsidy()}, \n" +
                $"Net Salary: {CalculateNetSalary()}\n";
        }
    }
}
