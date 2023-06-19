Console.Write("Введите координату x точки A: ");
int ax = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату y точки A: ");
int ay = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату z точки A: ");
int az = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату x точки B: ");
int bx = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату y точки B: ");
int by = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Введите координату z точки B: ");
int bz = Convert.ToInt32(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));

Console.WriteLine($"Растояние между AB = {AB:f2}");