namespace FactoryMethod;

public class CountryDiscountFactory : DiscountFactory
{
    private readonly string countryIdentifier;
    public CountryDiscountFactory(string countryIdentifier)
    {
        this.countryIdentifier = countryIdentifier;
    }

    public override DiscountService CreateDiscountService()
    {
        return new CountryDiscountService(countryIdentifier);
    }
}