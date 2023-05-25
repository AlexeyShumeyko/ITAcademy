public class MyStack<T>
{
    private T[] array = Array.Empty<T>();

    public T this[int index] => array[index];

    public void Push(T value)
    {
        var newArray = new T[array.Length + 1];

        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        newArray[array.Length] = value;

        array = newArray;
    }

    public T Pop()
    {
        var result = array[array.Length - 1];

        var newArray = new T[array.Length - 1];

        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = array[i];
        }

        array = newArray;

        return result;
    }
}