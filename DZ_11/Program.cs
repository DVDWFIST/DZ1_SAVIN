// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!


int Garbage(int number, int numGarbege)
{
    int sum = 1;
    for (int i = 1; i <= numGarbege; i++)
    {
        sum = sum * number;
    }
    return sum;
}

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Число {a} в степени {b} будет {Garbage(a, b)} ");