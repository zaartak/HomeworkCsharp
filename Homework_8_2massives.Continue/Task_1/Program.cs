// РЕШЕНА Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



Console.Write("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите кол-во строк в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int [,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
SortToLower(array);
Console.WriteLine();
int[,] sortarray = array;
PrintArray(sortarray);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод формирования массива, которая упорядочит по убыванию элементы каждой строки двумерного массива:
void SortToLower(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int v = 0; v < array.GetLength(1) - 1; v++)
            {
                if (array[i, v] < array[i, v + 1])
                {
                    int temp = array[i, v + 1];
                    array[i, v + 1] = array[i, v];
                    array[i, v] = temp;
                }
            }
        }
    }
}