// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

Console.Write("Введите число A: ");
int number = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{number}, {number1} -> {degree(number)}");

int degree(int A)
{
    int final = 1;
    for (int i = 1; i <= number1; i++)
    {
        final = number * final;
    }
    return final;
}