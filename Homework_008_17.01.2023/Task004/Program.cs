// Задача 60. ...Сформируйте трёхмерный массив из уникальных двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите количество листов трехмерного массива");
int lists = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк трехмерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов трехмерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,,] newarray = new int[lists, rows, cols];
FillArray(newarray);
PrintArray(newarray);

void FillArray(int[,,] array)
{
    int[] numlist = new int[array.Length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int numindex = i * (array.GetLength(1) * array.GetLength(2)) + j * (array.GetLength(2)) + k;
                array[i, j, k] = new Random().Next(10, 100);
                for (int l = 0; l < numindex; l++)
                {
                    while (array[i,j,k] == numlist[l])
                    {
                        array[i, j, k] = new Random().Next(10, 100);
                        l = 0;
                    }
                }
                numlist[numindex] = array[i, j, k];
            }
        }
    }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Лист №{i + 1}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],2}({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}
