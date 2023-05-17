// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} равна: {SumLine(M, N)}");


int SumLine(int M, int N)
{
    if (N < M) return 0;
    return N + SumLine(M, N - 1);
}