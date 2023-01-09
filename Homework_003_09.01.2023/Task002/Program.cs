// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Введите число осей");
int N = Convert.ToInt32(Console.ReadLine());
double[] dot1 = new double[N];
double[] dot2 = new double[N];
int i = 0;
double distance = 0;
while (i < N)
{
    Console.WriteLine($"Введите координату первой точки по оси №{i + 1}");
    dot1[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите координату второй точки по оси №{i + 1}");
    dot2[i] = Convert.ToInt32(Console.ReadLine());
    distance = distance + Sqare(dot1[i], dot2[i]);
    i++;
}

distance = Math.Sqrt(distance);
Console.WriteLine($"Расстояние между заданными точками равно: {Math.Round(distance,3)}");

double Sqare(double x1, double x2)
{
    double result = 0;
    result = Math.Pow(x2 - x1, 2);
    return result;
}



