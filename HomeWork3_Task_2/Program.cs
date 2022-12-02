// Найти все числа, большее 200 и меньше 500, которое нацело делится на 17.
// Реализовать через цикл While(). На выходе мы должны получить строку, где
// числа разделены ‘,’

using System.Text;

var i = 200;
StringBuilder sb = new();

while(i <= 500)
{

    if(i % 17 == 0)
    {
        
        sb.Append(i);
        sb.Append(",");
        
    }
    i++;
    
}

Console.WriteLine(sb);