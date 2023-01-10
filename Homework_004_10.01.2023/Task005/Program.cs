// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

Console.WriteLine("Введите длину массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] mainarray = new int[N];
fillarray(mainarray);
Console.WriteLine("Сгенерированный первоначальный массив:");
printarray(mainarray);
printresult(resultarray(mainarray));
printarray(mainarray);

void fillarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
}
void printarray(int[] newarray)
{
    foreach (var item in newarray)
    {
        Console.Write(item + " ");
    }
}
double[] resultarray(int[] arr1)
{
    double[] result = new double[6];
    result[0] = arr1[0]; // Минимальное значение входящего массива;
    result[1] = 0; // Индекс вышеуказанного минимального значения (Объявление данного элемента не обязательно, сделано с целью наглядности);
    result[2] = arr1[1]; // Максимальное значение входящего массива;
    result[3] = 0; // Индекс вышеуказанного минимального значения (Объявление данного элемента не обязательно, сделано с целью наглядности);
    result[4] = 0; // Среднее арифметическое значений массива (Объявление данного элемента не обязательно, сделано с целью наглядности);
    result[5] = 0; // Медианное значение входящего массива (Объявление данного элемента не обязательно, сделано с целью наглядности);
    for (int i = 0; i < arr1.Length; i++)
    {
        if (result[0] < arr1[i])
        {
            result[0] = arr1[i];
            result[1] = i;
        }
        else if (result[2] > arr1[i])
        {
            result[2] = arr1[i];
            result[3] = i;
        }
        result[4] = result[4] + arr1[i];
    }
    result[4] = Math.Round(result[4] / arr1.Length, 2);
    double[] tempmass = new double[mainarray.Length]; // создаем временный массив, для того,
    Array.Copy(mainarray, tempmass, mainarray.Length); // чтобы не перезаписывать первоначальный
    for (int i = 0; i < arr1.Length; i++)
    {
        double temp = 0;
        for (int j = i + 1; j < tempmass.Length; j++)
        {
            if (tempmass[i] > tempmass[j])
            {
                temp = tempmass[i];
                tempmass[i] = tempmass[j];
                tempmass[j] = temp;
            }
        }
    }
    if (N % 2 == 0) result[5] = (tempmass[N/2] + tempmass[(N/2)-1])/2;
    else result[5] = tempmass[N/2];
    return result;
}
void printresult(double[] arr2)
{
    Console.WriteLine(" ");
    Console.WriteLine("Результаты обработки сгенерированного массива:");
    Console.WriteLine($"{arr2[0]} - Минимальное значение сгенерированного массива");
    Console.WriteLine($"{arr2[1]} - Индекс вышеуказанного минимального значения");
    Console.WriteLine($"{arr2[2]} - Максимальное значение сгенерированного массива");
    Console.WriteLine($"{arr2[3]} - Индекс вышеуказанного минимального значения");
    Console.WriteLine($"{arr2[4]} - Среднее арифметическое значений массива");
    Console.WriteLine($"{arr2[5]} - Медианное значение сгенерированного массива");
}
