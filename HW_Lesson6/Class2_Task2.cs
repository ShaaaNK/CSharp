namespace HW_Lesson6_Task_1;

public class Cone
{
    const decimal pi = 3.141592M;
    decimal radius;
    decimal height;

    public Cone(decimal radius)
    {
        this.radius = radius;
        _ = height;
    }

    public Cone(decimal radius, decimal height)
    {
        this.radius = radius;
        this.height = height;
    }
    
    public void CircleSquare()
    {
        var square = pi * (radius * radius);
        Console.WriteLine($"Cone sinking surface area = {square}");
        
    }
    
    public void FullSquare()
    {
        var fullSquare = pi * radius * ((decimal)Math.Sqrt((double)(radius * radius) + (double)(height * height)) + radius);
        Console.WriteLine($"Full cone square {fullSquare}");
    }
}