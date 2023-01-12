// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] newarray = new int[N];
Randomize(newarray);
Console.WriteLine("Сгенерированный массив:");
Printarray(newarray);
Summodd(newarray);


void Randomize(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}
void Printarray(int[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}
void Summodd(int[] array2)
{
    int sum = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (i % 2 != 0) sum = sum + array2[i];
    }
    Console.WriteLine($"Сумма чисел на нечетных позициях в массиве: {sum}");
}
