namespace FactoryMethod;

public class CountryDiscountService : DiscountService
{
    private readonly string countryIdentifier;

    public CountryDiscountService(string countryIdentifier)
    {
        this.countryIdentifier = countryIdentifier;
    }

    public override int DiscountPercentage
    {
        get
        {
            return countryIdentifier switch
            {
                "BR" => 20,
                _ => 10
            };
        }
    }
}