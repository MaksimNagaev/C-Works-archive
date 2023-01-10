// Использование функций обязательно, начиная с этого ДЗ!
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

try
{
Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число - для возведения в степень первого числа");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(mathPowAlternate(a, b));
}
catch
{
    Console.WriteLine($"Вы ввели неверные данные");
}
int mathPowAlternate(int x, int y)
{
    int result = 1;
    for (int i = 0; i < y; i++)
    {
        result = result * x;
    }
    return result;
}
