public class CurrencyRequest
{
    public Currency From { get; set; }
    public Currency To { get; set; }
    public decimal Amount { get; set; }

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