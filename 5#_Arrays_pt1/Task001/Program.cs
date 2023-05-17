// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. |
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] newarray = new int[N];
Randomize(newarray);
Console.WriteLine("Сгенерированный массив:");
Printarray(newarray);
Findeven(newarray);

void Randomize(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 1000);
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
void Findeven(int[] array2)
{
    int count = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i] % 2 == 0) count +=1;
    }
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}