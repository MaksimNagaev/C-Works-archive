﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4

// Т.к. данные задачи аналогичны друг другу, решение будет общим для обеих:


Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (a > index) index = index * 10;
if (index <= 100) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine((a % (index / 100)) / (index / 1000));