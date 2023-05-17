// Задача 6sem VERY HARD необязательная Имеется список чисел. Создайте список, в который попадают числа, описывающие максимальную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.
// Пример:
// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]
// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5]
// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5]

Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int[] minmax = new int[2];
FillArray(array);
PrintArray(array);
PrintArray(FindList(array));

int[] FindList(int[] array)
{
    int[] result = new int[2];
    int count = 0; // длина последовательности
    int maxcount = 0;
    int start = 0;
    int end = 0;
    for (int i = 0; i < array.Length; i++)
    {
        start = array[i];
        count = 0;
        for (int j = 0; j < array.Length; j++)
        {
            if (start + count + 1 == array[j])
            {
                end = array[j];
                count += 1;
                j = -1;
            }
        }
        if (count > maxcount) 
        {
            result[0] = start;
            result[1] = end;
            maxcount = count;
        }
    }

    return result;
}
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 20);
}
void PrintArray(int[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}