// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;
if (number >= i)
{
    Console.WriteLine($"Список чётных чисел в диапазоне (1; {number}):");
    while (i <= number)
    {
        Console.Write(i + " ");
        i = i + 2;
    }
}
else Console.WriteLine($"Чётные числа в диапазоне (1; {number}) отстутствуют");