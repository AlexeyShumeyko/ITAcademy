public static class ConversionArrayRankExtensions
{
    public static int[] GhangeArrayDimension(this int[,] inputArray)
    {
        int [] newArray = new int[inputArray.Length];

        for (int i = 0, n = 0; i < inputArray.GetLength(0); i++)
            for(int j = 0; j < inputArray.GetLength(1); j++)
            {
                newArray[n] = inputArray[i, j];
                n++;
            }

        return newArray;
    }
    public static int[,] GhangeArrayDimension(this int[] inputArray, int dimension) // Перегрузка для задания "С"
    {
        int width = (int)Math.Ceiling((double)inputArray.Length / dimension);
        int[,] newArray = new int[width, dimension];

        for (int i = 0; i < newArray.GetLength(0); i++)
            for(int j = 0; j < newArray.GetLength(1); j++)
            {
                int count = i * dimension + j;
                if (count == inputArray.Length)
                    break;
                newArray[i, j] = inputArray[count];
            }
        return newArray;
    }
}