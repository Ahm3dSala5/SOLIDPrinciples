namespace InterfaceSegregation.After
{
    public class Staff : Employee , IBounsesEntitlement, IHealthInsuranceEntitlement, IPensionEntitlement, IRentalSubsidyEntitlement
    {
        public decimal CalculateBounses() => Salary * 0.05m;

        public decimal CalculateHealthInsurance() => 300m;

        public decimal CalculatePension() => Salary * 2.5m;

        public decimal CalculateRentalSubsidy() => 150m;

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
