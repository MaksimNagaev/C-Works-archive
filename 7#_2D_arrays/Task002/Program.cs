// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] newarray = new int[rows, cols];
FillArray(newarray);
PrintArray(newarray);
FindNumber(newarray);


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
void FindNumber(int[,] array1)
{
    Console.WriteLine("Введите искомое значение");
    int search = Convert.ToInt32(Console.ReadLine());
    int[] result = new int[2];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (array1[i, j] == search) 
            {
                result[0] = i;
                result[1] = j;
                break;
            }
        }
        if (result[0] !=0) break;
    }
    if (result[0] !=0) Console.WriteLine($"Индекс искомого значения равен: [{result[0]},{result[1]}]");
    else Console.WriteLine($"Искомое значение в массиве отсутствует");
}