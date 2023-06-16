﻿//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if(number >= 100 & number < 1000)
{
    number = number % 10;
    Console.Write($"{number}");
}

if(number >= 1000 & number < 10000)
{
    number = (number % 100) / 10;
    Console.Write($"{number}");
}
if(number >= 10000 & number < 100000)
{
    number = (number / 100) % 10;
    Console.Write($"{number}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}