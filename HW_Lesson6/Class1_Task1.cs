namespace HW_Lesson6_Task_1;
/// <summary>
/// Реверс значений массива
/// </summary>
public class ArrayWorker
{
    /// <summary>
    /// Метод для представления элементов массива в обратном порядке
    /// </summary>
    /// <param name="arr">Числовой массив </param>
    /// <returns>Числовой массив</returns>
    public static int [] InvertArr(int[] arr)
    {
        Array.Reverse(arr);
        return arr;
    }
}