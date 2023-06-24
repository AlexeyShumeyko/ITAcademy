public static class MyMath
{


    public static int Factorial(int number)
    {
        if (number == 1) return 1;

        try
        {
            return number * Factorial(number - 1);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex);
            return -1;
        }
    }

    public static int Exponentiation(int number, int degree)
    {
        var result = 1;
        for (int i = 0; i < degree; i++)
        {
            result *= number;
        }
        return result;
    }

}