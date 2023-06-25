// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: "); 
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);
int countevennumbers = 0;

foreach(int el in array)
{
    if(el % 2 == 0)
    {
        countevennumbers = countevennumbers +1;
    }
}

int[] GetArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 999);
    }
    return result;
}

Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
Console.Write($"Количество четных элементов в массиве: {countevennumbers}");