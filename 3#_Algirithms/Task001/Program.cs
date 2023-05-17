// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет,
// является ли оно палиндромом. Через строку нельзя решать само собой.

Console.WriteLine("Введите число для дальнейшего анализа");
int x = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index < x) index = index * 10;

// Console.WriteLine(index);

if (Check(x, index)) Console.WriteLine($"Заданное число: {x} - палиндром");
else Console.WriteLine($"Заданное число: {x} - не палиндром");

Boolean Check(int x, int index)
{
    int count = 1;
    Boolean result = false;
    while (count < index)   // так и не смог придумать как заменить здесь while на for.
    {
        if ((((x % (index / count)) / (index / (10 * count)))) == ((x % (10 * count)) / count)) result = true;
        else
        {
            result = false;
            break;
        }
        count = count * 10;
    }
    return result;
}