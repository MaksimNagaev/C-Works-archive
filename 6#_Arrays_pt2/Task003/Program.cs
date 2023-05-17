// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - 
// площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

double[] array = new double[3];
Console.WriteLine("Введите длину первой стороны a");
array[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны b");
array[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны c");
array[2] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задан треугольник со сторонами:");
PrintArray(array);
Showinfo(array);

void Showinfo(double[] array)
{
    if (array[0] > array[1] + array[2] || array[1] > array[0] + array[2] || array[2] > array[0] + array[1])
    {
        Console.WriteLine("Данный треугольник не может существовать");
    }
    else
    {
        Console.WriteLine("Треугольник с данными параметрами может существовать");
        double P = (array[0] + array[1] + array[2]);
        Console.WriteLine($"Периметр данного треугольника составит: {P}");
        double ab = Math.Round(((Math.Acos((Math.Pow(array[0], 2) + Math.Pow(array[1], 2) - Math.Pow(array[2], 2)) / (2 * array[0] * array[1]))) * 180 / Math.PI), 3);
        double ac = Math.Round(((Math.Acos((Math.Pow(array[0], 2) + Math.Pow(array[2], 2) - Math.Pow(array[1], 2)) / (2 * array[0] * array[2]))) * 180 / Math.PI), 3);
        double bc = Math.Round(((Math.Acos((Math.Pow(array[1], 2) + Math.Pow(array[2], 2) - Math.Pow(array[0], 2)) / (2 * array[1] * array[2]))) * 180 / Math.PI), 3);
        Console.WriteLine($"Углы треугольника в градусах равны: ab = {ab}, ac = {ac}, bc = {bc}");
        double S = Math.Round(Math.Sqrt((P / 2) * ((P / 2) - array[0]) * ((P / 2) - array[1]) * ((P / 2) - array[2])), 3);
        Console.WriteLine($"Площадь треугольника будет равна: {S}");
        if (ab == 90 || ac == 90 || bc == 90) Console.WriteLine("Данный треугольник является прямоугольным");
        if (ab == ac && ab == bc) Console.WriteLine("Данный треугольник является равносторонним");
        else if (ab == ac || ac == bc || bc == ab) Console.WriteLine("Данный треугольник является равнобедренным");
    }
}
void PrintArray(double[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        Console.Write($"{mas[i]} ");
    Console.WriteLine();
}