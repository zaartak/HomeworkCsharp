// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,  
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// i = 1, j = 2 -> 2 
// i = 4, j = 2 -> такого элемента не существует 
 
 
Console.Write("Введите размер строки: "); 
int rows = int.Parse(Console.ReadLine()!); 
 
Console.Write("Введите количество столбцов: "); 
int columns = int.Parse(Console.ReadLine()!); 
 
Console.Write("Введите номер строки: "); 
int numrows = int.Parse(Console.ReadLine()!); 
 
Console.Write("Введите размер столбца: "); 
int numcolumns = int.Parse(Console.ReadLine()!); 
 
 
int [,] newArray = GetArray(rows,columns, 0, 10); 
PrintArray(newArray); 
findelement(newArray, numrows, numcolumns); 
 
 
// Метод заполнения двумерного массива  
 
int[,] GetArray(int m, int n, int minValue, int maxValue){ 
    int[,] result = new int[m,n]; 
    for(int i = 0; i < m; i++){ 
        for(int j = 0; j < n; j++){ 
            result[i,j] = new Random().Next(minValue, maxValue); 
        } 
    } 
    return result; 
} 
 
// Метод нахождения элемента массива и проверки на его существования в массиве 
 
void findelement(int[,] inArray, int row, int column) 
{ 
   if(row < inArray.GetLength(0) && column <= inArray.GetLength(1)) 
   { 
        Console.Write($"строка - {numrows}, столбец - {numcolumns} -> {inArray[row,column]}"); 
   } 
   else Console.Write($"такого элемента не существует"); 
} 
 
 
 // Метод вывода двумерного массива 
void PrintArray(int[,] inArray) 
{ 
    for(int i = 0; i < inArray.GetLength(0); i++) 
    { 
        for(int j = 0; j < inArray.GetLength(1); j++) 
        { 
            Console.Write($"{inArray[i,j]} "); 
        } 
        Console.WriteLine(); 
    } 
}