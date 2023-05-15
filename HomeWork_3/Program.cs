List<decimal> conversionMoney = new List<decimal>();
Dictionary<int, double> valueCollectionMemory = new Dictionary<int, double>();

var request = new CurrencyExchangeRequest(Currency.USD, Currency.RUB, 30.60M, valueCollectionMemory);
conversionMoney.Add(request.ConvertCurrency(request));

var request2 = new CurrencyExchangeRequest(Currency.BYN, Currency.RUB, 679, valueCollectionMemory);
conversionMoney.Add(request2.ConvertCurrency(request2));

var request3 = new CurrencyExchangeRequest(Currency.USD, Currency.RUB, 30.60M, valueCollectionMemory);
conversionMoney.Add(request3.ConvertCurrency(request3));

var request4 = new CurrencyExchangeRequest(Currency.BYN, Currency.RUB, 679, valueCollectionMemory);
conversionMoney.Add(request4.ConvertCurrency(request4));

Console.WriteLine(string.Join(" ", conversionMoney));

public enum Currency
{
    BYN = 21,
    RUB = 45,
    EUR = 34,
    USD = 38
}