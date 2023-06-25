// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: "); 
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size);
int sum = 0;

int[] GetArray(int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}



for(int i = 1; i < array.Length; i += 2)
{
    sum = sum + array[i];
}

Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
Console.Write($"Сумма элементов, стоящих на нечётных ИНДЕКСАХ: {sum}");