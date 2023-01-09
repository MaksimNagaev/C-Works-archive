// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

try
{
    Console.WriteLine("Введите целое положительное число");
    int x = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= x; i++) Console.Write($"{Math.Pow(i, 3)} ");
}

catch
{
    Console.WriteLine("Вы ввели неверные данные");
}

