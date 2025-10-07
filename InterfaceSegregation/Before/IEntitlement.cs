namespace InterfaceSegregation.Before
{
    public interface IEntitlement
    {
        decimal CalculateBounses();
        decimal CalculateHealthInsurance();
        decimal CalculatePension();
        decimal CalculateRentalSubsidy();
        decimal CalculateTransportation();
    }
}
