using System.Text;
public static class DuplicateSimbolExtensions
{
    public static string DuplicateThirdSimbol(this string inputString)
    {
        var outputString = new StringBuilder();

        for (int i = 0; i < inputString.Length; i++)
        {
            if((i + 1) % 3 == 0)
            {
                outputString.Append(inputString[i]);
            }

            outputString.Append(inputString[i]);
        }

        return outputString.ToString();
    }
}