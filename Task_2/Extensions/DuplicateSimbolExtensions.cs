using System.Text;
public static class DuplicateSimbolExtensions
{
    public static string DuplicateThirdSimbol(this string inputString)
    {
        var outputString = new StringBuilder();

        for (int i = 0, j = 2; i < inputString.Length; i++)
        {
            if(i == j)
            {
                outputString.Append(inputString[i]);
                outputString.Append(inputString[i]);
                j += 3;
            }
            else outputString.Append(inputString[i]);
        }

        return outputString.ToString();
    }
}