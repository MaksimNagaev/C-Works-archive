// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое целое число");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y) Console.WriteLine($"Первое введенное число: {x} - является максимальным");
else if (x<y) Console.WriteLine($"Второе введенное число: {y} - является максимальным");
else Console.WriteLine($"Введенные значения: {x} - равны друг другу");
