namespace HW_Lesson6_Task_1;
/// <summary>
/// Вычисление геометрических параметров конуса
/// </summary>
public class Cone
{
    const decimal pi = 3.141592M;
    decimal radius;
    decimal height;
    /// <summary>
    /// Метод определения входных параметров для вычисления площади основания конуса
    /// </summary>
    /// <param name="radius">Радиус оснвоания конуса</param>
    public Cone(decimal radius)
    {
        this.radius = radius;
        _ = height;
    }
/// <summary>
/// Метод определения входных параметров для вычисления полной площади конуса
/// </summary>
/// <param name="radius">Радиус основания конуса</param>
/// <param name="height">Высота конуса</param>
    public Cone(decimal radius, decimal height)
    {
        this.radius = radius;
        this.height = height;
    }
    /// <summary>
    /// Вычисление площади основания конуса
    /// </summary>
    public void CircleSquare()
    {
        
        var square = pi * (radius * radius);
        Console.WriteLine($"Cone sinking surface area = {square}");
        
    }
    /// <summary>
    /// Вычисление полной площади конуса
    /// </summary>
    public void FullSquare()
    {
        var fullSquare = pi * radius * ((decimal)Math.Sqrt((double)(radius * radius) + (double)(height * height)) + radius);
        Console.WriteLine($"Full cone square {fullSquare}");
    }
}