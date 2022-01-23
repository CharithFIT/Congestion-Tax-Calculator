namespace CongestionTaxCalculator.Repository
{
    public class DbInitializer
    {
        public static void Initialize(CongestionTaxCalculatorDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
