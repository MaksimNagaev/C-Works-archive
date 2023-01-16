// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , 
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. 
// Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и 
// только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. 
// То есть если массив три на четыре, то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.

Console.WriteLine("Введите параметры массива с четным количеством элементов");
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] newarray = new int[rows, cols];
if (rows % 2 != 0 && cols % 2 != 0)
{
    Console.WriteLine("Количество элементов является нечетным - выполнение невозможно");
    return;
}
FillArray(newarray);
PrintArray(newarray);
ShuffleArray(newarray);
PrintArray(newarray);

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
void ShuffleArray(int[,] array)
{
    bool[,] temp = new bool[array.GetLength(0), array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (temp[i, j] == false)
            {
                temp[i, j] = true;
                int irand = new Random().Next(0, array.GetLength(0));
                int jrand = new Random().Next(0, array.GetLength(1));
                while (temp[irand, jrand] == true)
                {
                    irand = new Random().Next(0, array.GetLength(0));
                    jrand = new Random().Next(0, array.GetLength(1));
                }
                (array[i, j], array[irand, jrand]) = (array[irand, jrand], array[i, j]);
                temp[irand, jrand] = true;
                count += 1;
                Console.WriteLine($"Произведена замена №{count} между элементами: {array[irand, jrand]} и {array[i, j]}");
            }
        }
    }
}