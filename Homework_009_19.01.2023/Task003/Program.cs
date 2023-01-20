// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0) { Console.WriteLine("Вы ввели неверные данные"); return; }
Console.WriteLine($"Значение функции Аккермана при заданных числах равно: {Akr(m, n)}");

int Akr(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akr(m - 1, 1);
    return Akr(m - 1, Akr(m, n - 1));
}