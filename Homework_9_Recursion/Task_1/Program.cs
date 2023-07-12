﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);


Console.WriteLine($"{Nto1(N,1) }");

string Nto1(int start, int end)
{
    if(start == end) return start.ToString();
    return (start +" "+ Nto1(start - 1, end));
}

