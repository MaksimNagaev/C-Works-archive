// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите размер стороны квадратного массива");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = rows;
int maxlay = rows / 2; // Вводим переменную, отражающую максимальное количество "слоев" данного массива;
if (rows % 2 != 0) maxlay += 1;
int[,] newarray = new int[rows, cols];
FillSpiral(newarray);
PrintArray(newarray);

void FillSpiral(int[,] array)
{
    int count = 0;
    for (int curlay = 0; curlay < maxlay; curlay++) // счетчик - это текущий "слой";
    {
        for (int i1 = (0 + curlay); i1 < (array.GetLength(0) - curlay); i1++)
        {
            count++;
            array[curlay, i1] = count;
        }
        count--;
        for (int i2 = (0 + curlay); i2 < (array.GetLength(0) - curlay); i2++)
        {
            count++;
            array[i2, array.GetLength(0) - 1 - curlay] = count;
        }
        count--;
        for (int i3 = (array.GetLength(0) - curlay); i3 > (0 + curlay); i3--)
        {
            count++;
            array[array.GetLength(0) - 1 - curlay, i3 - 1] = count;
        }
        count--;
        for (int i4 = (array.GetLength(0) - curlay); i4 > (1 + curlay); i4--)
        {
            count++;
            array[i4 - 1, curlay] = count;
        }
    }
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
