﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите целое трехзначное число");
int x = Convert.ToInt32(Console.ReadLine());

if (x > 99 && x < 1000) Console.WriteLine((x%100)/10);
else Console.WriteLine($"Введенное вами число не удовлетворяет заданным условиям");