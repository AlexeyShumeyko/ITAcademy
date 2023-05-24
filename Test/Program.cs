using System.Text;

// Task1

int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };

Console.Write("{");
for (int i = 0; i < mas.GetLength(0); i++)
{
    Console.Write("{");
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write("{");
        for (int k = 0; k < mas.GetLength(2); k++)
        {
            Console.Write($"{mas[i, j, k]},");
        }
        Console.Write("}");
    }
    Console.Write("}");
}

// Task2

var result = new MyString("abcdef");
Console.WriteLine(result.Reverse());
class MyString
{
    private string Value { get; set; }
    private string Value2 { get; set; } = "";

    public MyString(string value1)
    {
        Value = value1;
    }
    public MyString(string value1, string value2) : this(value1)
    {
        Value2 = value2;
    }

    public string Reverse()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = Value.Length - 1; i >= 0; i--)
        {
            sb.Append(Value[i]);
        }

        for (int i = Value2.Length - 1; i >= 0; i--)
        {
            sb.Append(Value2[i]);
        }

        return sb.ToString();
    } 
}

// Task 3

public static class DateExtension
{
    static string dateTime1 (this DateTime dateTime)
    {
        dateTime.GetDateTimeFormats("")
        return "";
    }
}