// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"A({M},{N}) = {Akkerman(M,N)}");

int Akkerman(int num1, int num2)
{
    if(num1 == 0) return num2 + 1;
    if(num2 == 0) return Akkerman(num1 - 1, 1);
    return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));
}