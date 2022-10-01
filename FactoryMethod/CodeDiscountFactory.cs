namespace FactoryMethod;

public class CodeDiscountFactory : DiscountFactory
{
    private readonly Guid code;

    public CodeDiscountFactory(Guid code)
    {
        this.code = code;
    }
    public override DiscountService CreateDiscountService()
    {
        return new CodeDiscountService(code);
    }
}