public class ConvertCurrency
{
    private Dictionary<(CurrencyRequest.Currency From, CurrencyRequest.Currency To), decimal> ValueCollectionMemory { get; set; }
    public ConvertCurrency()
    {
        ValueCollectionMemory = new Dictionary<(CurrencyRequest.Currency From, CurrencyRequest.Currency To), decimal>();
    }
    public decimal Convert(CurrencyRequest request)
    {

        if (ValueCollectionMemory.ContainsKey((request.From, request.To)))
        {
            var rate = ValueCollectionMemory[(request.From, request.To)];

            return rate * request.Amount;
        }
        else
        {
            ValueCollectionMemory.Add((request.From, request.To), GetRandomValue());

            var rate = ValueCollectionMemory[(request.From, request.To)];

            return rate * request.Amount;
        }
    }
    private decimal GetRandomValue()
    {
        var randomValue = new Random();

        return (decimal)randomValue.NextDouble() * 3;
    }
}
