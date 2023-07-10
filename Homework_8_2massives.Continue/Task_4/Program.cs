// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Введите кол-во столбцов в массивах: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите кол-во строк в массивах: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите кол-во 3d в массивах: ");
int d3 = int.Parse(Console.ReadLine()!);

int[,,] array = GetArray(rows, columns, d3, 10, 99);

PrintArray(array);


// Метод получения трехмерного массива 

int[,,] GetArray(int m, int n, int l, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, l];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return result;
}

// Метод вывода трехмерного массива с показом номера элемента
void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}