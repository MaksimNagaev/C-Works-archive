// задача 2 HARD необязательная. Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс. 
// Вывести эту информацию на экран.

Console.WriteLine("Введите высоту массива");
int H = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
int[,] newarray = new int[H, N];
Randomize(newarray);
Printarray(newarray);
MinMaxFind(newarray);


void Randomize(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}
void Printarray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}
void MinMaxFind(int[,] array2)
{
    int min = array2[0, 0];
    int imin = 0;
    int jmin = 0;
    int max = array2[0, 0];
    int imax = 0;
    int jmax = 0;
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (min > array2[i, j])
            {
                min = array2[i, j];
                imin = i;
                jmin = j;
            }
            else if (max < array2[i, j])
            {
                max = array2[i, j];
                imax = i;
                jmax = j;
            }
        }
    }
    Console.WriteLine($"Минимальное значение массива равно {min} [{imin},{jmin}]");
    Console.WriteLine($"Минимальное значение массива равно {max} [{imax},{jmax}]");
}