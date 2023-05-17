// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] newarray = new int[rows, cols];
int[,] newarray2 = new int[rows, cols];
FillArray(newarray);
FillArray(newarray2);
Console.WriteLine("Сгенерированный массив №1:");
PrintArray(newarray);
Console.WriteLine("Сгенерированный массив №2:");
PrintArray(newarray2);
Console.WriteLine("Результирующий массив:");
PrintArray(MultArray(newarray, newarray2));

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
int [,] MultArray(int[,] array1, int[,] array2)
{
    int[,] result = new int [array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array1.GetLength(1); j++)
            result[i,j] = array1[i,j] * array2[i,j];
    return result;
}