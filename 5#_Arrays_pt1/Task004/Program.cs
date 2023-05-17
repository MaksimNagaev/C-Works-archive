// Задача 30: - HARD необязательная Напишите программу, которая на вход получает размерность массива. 
// Далее заполняет его случайными уникальными числами и выводит на экран. 
// Далее производим сортировку массива от большего к меньшему и выводим на экран. 
// Далее придумываем алгоритм перемешивания списка на основе случайности , применяем этот алгоритм и выводим на экран результат. 
// Встроенные методы работы со списками использовать нельзя.

Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] newarray = new int[N];
RandomUniq(newarray);
Console.WriteLine("Сгенерированный массив:");
Printarray(newarray);
Sortarray(newarray);
Console.WriteLine("Сортированный массив:");
Printarray(newarray);
Shufflearray(newarray);
Console.WriteLine("Перемешанный массив:");
Printarray(newarray);


void RandomUniq(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-N * 5, N * 5);
        for (int j = 0; j < i; j++)
        {
            bool isUniq = false;
            while (isUniq == false)
            {
                if (array[j] == array[i])
                {
                    isUniq = false;
                    array[i] = new Random().Next(1, 10);
                    j = 0;
                }
                else isUniq = true;
            }
        }
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
void Sortarray(int[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        int temp = 0;
        for (int j = i + 1; j < array2.Length; j++)
        {
            if (array2[i] < array2[j])
            {
                temp = array2[i];
                array2[i] = array2[j];
                array2[j] = temp;
            }
        }
    }
}
void Shufflearray(int[] array3)
{
    int temp = array3[0];
    int irand = 0;
    for (int i = 0; i < array3.Length; i++)
    {
        irand = new Random().Next(0, (array3.Length - 1));
        temp = array3[i];
        array3[i] = array3[irand];
        array3[irand] = temp;
    }
}

