// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Укажите желаемое число чисел");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество значений больше 0 равно {CheckArray(N)}");
int CheckArray(int N)
{
    int count = 0;
    int[] result = new int[N];
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите число № {i + 1}");
        result[i] = Convert.ToInt32(Console.ReadLine());
        if (result[i] > 0) count += 1;
    }
    return count;
}
