// See https://aka.ms/new-console-template for more information
var pi = 3.141592653M;
var e = 1.414213562373095048M;
Console.WriteLine($"PI = {pi}\nPythagoras number = {e}");
Console.ReadKey();
// Task № 3
var a = 3;
byte b ;
b = Convert.ToByte(a);
Console.WriteLine($"Byte b = {b}");
// Task № 4
Console.WriteLine("Enter 3 numbers");
int.TryParse(Console.ReadLine(), out var firstNumber);
int.TryParse(Console.ReadLine(), out var secondNumber);
int.TryParse(Console.ReadLine(), out var thirdNumber);
var average = (firstNumber + secondNumber + thirdNumber) / 3;
Console.WriteLine($"Average = {average}");
// Task № 5
Console.WriteLine("Enter your name");
var name = Console.ReadLine();
Console.WriteLine($"Hi {name}");