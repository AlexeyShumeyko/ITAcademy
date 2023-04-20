// Задание №1
int[] inputData = new int[] { 0, 2, 1, 5, 3, 4 };
int[] outputData = GetChangeArray(inputData);

Console.WriteLine($"Output: {String.Join(" ", outputData)}");

// Задание №2
int[] inArray = new int[] { 1, 1, 2, 45, 23, 5, 8, 1, 55, 23, 5, 60 };
int[] outArray = RemoveDuplicateItem(inArray);

Console.WriteLine($"Длина массива: {outArray.Length} // Массив: {String.Join(" ", outArray)}");

static int[] GetChangeArray(int[] input)
{
    int[] output = new int[input.Length];

    for (int i = 0; i < input.Length; i++)
    {
        output[i] = input[input[i]];
    }
    return output;
}

static int[] RemoveDuplicateItem(int[] inArray)
{
    var countRepetition = 0;

    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if(inArray[i] == inArray[j])
            {
                countRepetition++;
                break;
            }
        }
    }

    int[] outArray = new int[inArray.Length - countRepetition];

    for (int i = 0, n = 0; i < inArray.Length; i++)
    {
        var duplicate = false;

        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] == inArray[j])
            {
                duplicate = true;
                break;
            }
        }

        if (duplicate) continue;

        outArray[n] = inArray[i];
        n++;
    }
    return outArray;
}