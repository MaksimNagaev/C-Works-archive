// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] newarray = new int[rows, cols];
FillArray(newarray);
PrintArray(newarray);
FindAverage(newarray);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-19, 20);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3} \t");
        Console.WriteLine();
    }
}
void FindAverage(int[,] array1)
{
    double[] avg = new double [array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
            avg[j] = avg[j] + array1[i,j];
    }
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        avg[i] = Math.Round(avg[i] / array1.GetLength(0), 3);
        Console.WriteLine($"Среднее арифметичесое чисел в столбце {i} = {avg[i]}");
    }
}
