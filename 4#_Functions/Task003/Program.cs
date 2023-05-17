// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры 
// и далее выводит массив на экран в одну строку.

int[] arr = new int[8];
fillarray(arr);
printarray(arr);


void fillarray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите значение для эллемента массива под индеком {i}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void printarray(int[] newarray)
{
    foreach (var item in newarray)
    {
        Console.Write(item + " ");
    }
}