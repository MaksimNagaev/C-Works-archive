// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum1(x));

int sum1(int a)
{
    int result = 0;
    for (int i = 1; i < a; i = i * 10)
    {
        result = result + ((a / i) % 10);
    }
    return result;
}
