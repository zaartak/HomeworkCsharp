// Решена через Dictionary, нашел в интернете, получилось применить. Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза



Console.Write("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите кол-во строк в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int [,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);

int [] array2d = massiveconvert2d(array);

Console.WriteLine();

PrintArray2d(array2d);

Console.WriteLine();

PrintElementCounts(array2d);



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

// Метод конвертирования двухмерного массива в одномерный
int [] massiveconvert2d(int [,] inArray)
{
    int rows = inArray.GetLength(0);
    int columns = inArray.GetLength(1);
    int sumofel = rows * columns;
    int[] massive2d = new int[sumofel];

    int index2dmassive = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            massive2d[index2dmassive] = inArray[i,j];
            index2dmassive++;
        }
    }
    return massive2d;
}

// Метод вывода двухмерного массива в одномерном формате

void PrintArray2d(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        {
            Console.Write($"{inArray[i]} ");
        }
}

// Метод нахождения повторения элементов в двухмерном массиве

void PrintElementCounts(int[] array2d)
{
    Dictionary<int, int> counter = new Dictionary<int, int>();

    foreach (int element in array2d)
    {
        if (counter.ContainsKey(element))
        {
            counter[element]++;
        }
        else
        {
            counter[element] = 1;
        }
    }

    foreach (var pair in counter)
    {
        Console.WriteLine("Элемент: " + pair.Key + ", Количество повторений: " + pair.Value);
    }
}