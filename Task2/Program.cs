int[] numbers = { 3, 12, 4, 10 };
var orderedNumbers = numbers.OrderBy(n => n).ToArray();
var count = Math.Ceiling((decimal)orderedNumbers.Length / 2);
var res = orderedNumbers.Skip((int)count).Select(x => x*x);