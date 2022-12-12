void SortArr (int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j+1])
            {
                (array[j], array[j + 1]) = (array[j + 1], array[j]);
            }
        }
    }
}

void AddElementsOfArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Enter {i+1} from {array.Length} numbers");
        array[i] = int.Parse(Console.ReadLine());
    }  
}

int [] arr = new int[6];
AddElementsOfArray(arr);
SortArr(arr);
Console.Write(String.Join(",",arr));

