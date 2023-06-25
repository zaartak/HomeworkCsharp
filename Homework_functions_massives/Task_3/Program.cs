// Задача 38: Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [22, 42, 15, 77, 65] => 77 - 15 = 62

Console.Write("Введите размер массива: "); 
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);

int max = array[0];

int findmin(int minimum)
{
    int min = array[0];
    for (int i = 0; i < size; i++)
    {
        if( array[i] <= min)
        min = array[i];
    }
    return min;
}
int findmax(int maximum)
{
    int max = array[0];
    for (int i = 0; i < size; i++)
    {
        if( array[i] >= max)
        max = array[i];
    }
    return max;
}

int[] GetArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10,99);
    }
    return result;
}

int final = findmax(size) - findmin(size);

Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
Console.Write($"Разница между максимальным и минимальным элементов массива: {final}");