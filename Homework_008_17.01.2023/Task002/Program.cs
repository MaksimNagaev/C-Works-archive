// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] newarray = new int[rows, cols];
FillArray(newarray);
Console.WriteLine("Сгенерированный массив:");
PrintArray(newarray);
FindMinArray(newarray);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-9, 10);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2} \t");
        Console.WriteLine();
    }
}
void FindMinArray(int[,] array)
{
    int[] sumarray = new int[array.GetLength(0)];
    int minrow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sumarray[i] += array[i, j];
        int minsum = sumarray[0];
        if (sumarray[i] < minsum)
        {
            minsum = sumarray[i];
            minrow = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minrow + 1} строка");
}