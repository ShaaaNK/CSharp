int [,] arr = new int[3,3] {
                            {12,2,32},
                            {32,19,43},
                            {1,99,33}
                            };
for (int i = 0; i < arr.GetLength(0); i++)
{
    var max = arr[0, i];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i,j] > max)
        {
            max = arr[i,j];
            
        }
    }
    Console.WriteLine($"Max element of {i+1} row = {max}");
}

