namespace Bookify.Domain.Apartments;

public record Currency
{
    internal static readonly Currency None = new("");
    public static Currency Usd = new("USD");
    public static Currency Eur = new("EUR");
    private Currency(string code) => Code = code;
    public string Code { get; init; }

    public static Currency FromCode(string code)
    {
        return AllCurrencies.FirstOrDefault(x => x.Code == code) ??
               throw new ApplicationException("The currency code is invalid");
    }
    
    public static readonly IReadOnlyCollection<Currency> AllCurrencies = [Usd, Eur];
};