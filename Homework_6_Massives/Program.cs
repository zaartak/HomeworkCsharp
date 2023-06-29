// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите значение точки b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значение точки k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значение точки b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите значение точки k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// double findx(double k1, double b1, double k2, double b2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = (k2 * x) + b2;
//     return x;
// }
// double findy(double k1, double b1, double k2, double b2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = (k2 * x) + b2;
//     return y;
// }

// Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {findx(k1,b1,k2,b2)}; {findy(k1,b1,k2,b2)}");



// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите размер массива: "); 
// int size = int.Parse(Console.ReadLine()!);
// int[] array = GetArray(size);
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     if(array[i]> 0)
//     {
//        count = count +1;
//     }
// }

// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(-100, 999);
//     }
//     return result;
// }

// Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
// Console.Write($"Чисел больше 0: {count}");