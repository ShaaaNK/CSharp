using HW_Lesson6_Task_1;

int [] arr = {1,3,5};

Console.Write(String.Join(",", ArrayWorker.InvertArr(arr)));
Console.WriteLine("\n\t********** Task 2 **********");
// Console.WriteLine($"Cone sinking surface area {Cone.CircleSquare(5,6)}");
// Console.WriteLine($"Full cone square {Cone.FullSquare(5,6)}");
Cone circleSquare = new(3);
circleSquare.CircleSquare();
Cone fullConeSquare = new(3,5);
fullConeSquare.FullSquare();