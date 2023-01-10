// Задача 27. - HARD необязательная Напишите программу, которая принимает на вход целое 
// или дробное число и выдаёт количество цифр в числе.

// 452 -> 3
// 82 -> 2
// 9,012 ->4

Console.WriteLine("Введите число");
double N = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(numbercount(N));

double numbercount(double xy)
{
    int x = 0;
    for (int i = 1; ((N * i) % 1) != 0; i = i * 10)
    {
        x += 1;
    }
    for (int i = 1; i < N; i = i * 10)
    {
        x += 1;
    }
    return x;
}
