namespace CleanArquitecture.Application.DiscountStrategies
{
    public class BlackFridayDiscount : IDiscountStrategy
    {
        public double Calculate(double amount) => amount * 0.30;
    }
}
