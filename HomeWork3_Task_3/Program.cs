// bubble sort
int[] numbers = {1,3,4,3,1,5,6,7,8,9,3,2,1,5,7,9,8,7,6,4,2,1};
Sort.BubleSort(numbers);
foreach (var el in numbers)
{
    Console.Write($"{el},");
}
class Sort
{
    public static void BubleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1 ; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j+1])
                {
                    (array[j + 1], array[j]) = (array[j], array[j + 1]);
                }
            }
        }
    }
}

