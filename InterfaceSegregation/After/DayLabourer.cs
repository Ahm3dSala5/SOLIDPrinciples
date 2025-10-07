namespace InterfaceSegregation.After
{
    public class DayLabourer : Employee, IHealthInsuranceEntitlement, ITransportationEntitlement
    {
        public decimal CalculateHealthInsurance() => 300m;

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
