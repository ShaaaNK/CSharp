//Дано: у вас есть 3 промежутка чисел: от 0 до 30, от 31 до 60 и от 61 до 100.
//Входной параметр: пользователь вводит число.
//Что мы делаем: нужно понять в какой промежуток попало число.
//Выводим на консоль: в каком промежутке число. Если не попало, пишем “Я такого числа не знаю.”
CheckNumber();
void CheckNumber()
{
    Console.WriteLine("Enter a number :");
   // var userNumber = int.Parse(Console.ReadLine());
   int.TryParse(Console.ReadLine(), out var userNumber);
   if (CheckInterval.Check(userNumber) == 1)
   {
       Console.WriteLine("Your number part of interval from 0 to 30");
   }
   else if (CheckInterval.Check(userNumber) == 2)
   {
       Console.WriteLine("Your number part of interval from 31 to 60");
   }
   else if (CheckInterval.Check(userNumber) == 3)
   {
       Console.WriteLine("Your number part of interval from 61 to 100");
   }
   else if (CheckInterval.Check(userNumber) == 4)
   {
       Console.WriteLine("I dont now your number ");
   }
}

class CheckInterval
{
    public static int Check(int number)
    {
        switch (number)
        {
            case >= 0 and <=30: return 1;
            case >=31 and <=60: return 2;
            case >=61 and <= 100: return 3;
            default: return 4;
        }
    }
}
