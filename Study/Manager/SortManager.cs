namespace Study.Manager;

public class SortManager : Singleton<SortManager>
{
    public int[] InsertionSort(int[] array, int arrayLength)
    {
        for (int i = 1; i < arrayLength; i++)
        {
            var key = array[i];

            var j = i - 1;

            while (j >= 0 && array[j] >= key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }

            array[j + 1] = key;
        }

        return array;
    }
}