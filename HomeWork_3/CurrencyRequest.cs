public class CurrencyRequest
{
    public Currency From { get; private set; }
    public Currency To { get; private set; }
    public decimal Amount { get; private set; }

    public CurrencyRequest(Currency From, Currency To, decimal Amount)
    {
        this.From = From;
        this.To = To;
        this.Amount = Amount;
    }

    public enum Currency
    {
        BYN,
        RUB,
        EUR,
        USD
    }
}