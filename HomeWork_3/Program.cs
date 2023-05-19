List<decimal> conversionMoney = new List<decimal>();

var convertCurrency = new ConvertCurrency();

var request = new CurrencyRequest(CurrencyRequest.Currency.USD, CurrencyRequest.Currency.RUB, 30.60M);
conversionMoney.Add(convertCurrency.Convert(request));

request = new CurrencyRequest(CurrencyRequest.Currency.RUB, CurrencyRequest.Currency.USD, 679);
conversionMoney.Add(convertCurrency.Convert(request));

request = new CurrencyRequest(CurrencyRequest.Currency.USD, CurrencyRequest.Currency.RUB, 30.60M);
conversionMoney.Add(convertCurrency.Convert(request));

request = new CurrencyRequest(CurrencyRequest.Currency.RUB, CurrencyRequest.Currency.USD, 679);
conversionMoney.Add(convertCurrency.Convert(request));

Console.WriteLine(string.Join(" ", conversionMoney));