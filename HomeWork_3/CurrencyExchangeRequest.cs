public class CurrencyExchangeRequest
{
    private Currency From { get; set; }
    private Currency To { get; set; }
    private decimal Amount { get; set; }
    private Dictionary<int, double> ValueCollectionMemory { get; set; }

    public CurrencyExchangeRequest(Currency From, Currency To, decimal Amount, Dictionary<int, double> valueCollectionMemory)
    {
        this.From = From;
        this.To = To;
        this.Amount = Amount;
        ValueCollectionMemory = valueCollectionMemory;
    }

    public decimal ConvertCurrency(CurrencyExchangeRequest request)
    {
        var rateCurrency = СheckMemoryCollection(From, To);

        return (decimal)rateCurrency * request.Amount;
    }

    private double СheckMemoryCollection(Currency From, Currency To)
    {
        int KeyСurrency = ((int)From) * ((int)To) * 333;

        if (ValueCollectionMemory.ContainsKey(KeyСurrency))
        {
            return ValueCollectionMemory[KeyСurrency];
        }
        else
        {
            ValueCollectionMemory.Add(KeyСurrency, GetRandomValue());

            return ValueCollectionMemory[KeyСurrency];
        }
    }

    private double GetRandomValue()
    {
        var randomValue = new Random();

        return randomValue.NextDouble() * 3;
    }
}