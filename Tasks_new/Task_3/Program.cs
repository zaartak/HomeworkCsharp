// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.(использовать И и ИЛИ)
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите порядковый номер дня недели: "!);
int weekday = Convert.ToInt32(Console.ReadLine()!);

if(weekday == 1 & weekday == 2 & weekday == 3 & weekday == 4 & weekday == 5)
{
    Console.Write("Это будний день");
}
    
    if(weekday == 6 & weekday == 7);
{
    Console.Write("Это выходной день");
}