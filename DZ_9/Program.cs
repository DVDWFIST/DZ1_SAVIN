// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
double Distance(double a1, double a2, double a3, double b1, double b2, double b3)
{
    double pow_1 = Math.Pow((b1 - a1), 2);
    double pow_2 = Math.Pow((b2 - a2), 2);
    double pow_3 = Math.Pow((b3 - a3), 2);
    double result = Math.Sqrt(pow_1 + pow_2 + pow_3);
    return Math.Round(result, 3);
}


Console.WriteLine("Введите координаты точки для точки А:");

Console.WriteLine("координатa точки A-1:");
double a_1 = double.Parse(Console.ReadLine());

Console.WriteLine("координатa точки A-2:");
double a_2 = double.Parse(Console.ReadLine());

Console.WriteLine("координатa точки A-3:");
double a_3 = double.Parse(Console.ReadLine());


Console.WriteLine("Введите координаты точки B через пробел:");

Console.WriteLine("координатa точки B-1:");
double b_1 = double.Parse(Console.ReadLine());

Console.WriteLine("координатa точки B-2:");
double b_2 = double.Parse(Console.ReadLine());

Console.WriteLine("координатa точки -3:");
double b_3 = double.Parse(Console.ReadLine());


double sum = Distance(a_1, a_2, a_3, b_1, b_2, b_3);
Console.WriteLine($"Расстояние между точками в 3D пространсве равно {sum}");