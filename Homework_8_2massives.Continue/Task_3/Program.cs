// Решена! Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.Write("Введите кол-во столбцов в массивах: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите кол-во строк в массивах: ");
int columns = int.Parse(Console.ReadLine()!);

int [,] array = GetArray(rows, columns, 1, 10);
int [,] array2 = GetArray(rows, columns, 1, 10);
int [,] arrayfinal = multiplicationarrays(array, array2);

PrintArray(array);

Console.WriteLine();

PrintArray(array2);

Console.WriteLine();

PrintArray(arrayfinal);




// Метод получения двухмерного массива
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

// Метод вывода двухмерного массива
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

// метод умножения равных массивов поэлементно

int [,] multiplicationarrays(int[,] array1, int[,] array2)
{
    int[,] multiarray = new int[array1.GetLength(0),array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0) && i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1) && j < array2.GetLength(1); j++)
        {
            multiarray[i,j] = array1[i,j] * array2[i,j];
        }
    }
    return multiarray;
}