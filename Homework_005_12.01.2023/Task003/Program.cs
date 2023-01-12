// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
double[] newarray = new double[N];
Randomize(newarray);
Console.WriteLine("Сгенерированный массив:");
Printarray(newarray);
DeltaMinMax(newarray);


void Randomize(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().NextDouble() * 100), 2);
    }
}
void Printarray(double[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}
void DeltaMinMax(double[] array2)
{
    double min = array2[0];
    double max = array2[0];
    double delta = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (min < array2[i]) min = array2[i];
        else if (max > array2[i]) max = array2[i];
    }
    delta = Math.Round(max - min, 2);
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {delta}");
}