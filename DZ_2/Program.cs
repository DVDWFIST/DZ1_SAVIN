int Max(int num_1, int num_2, int num_3)
{
    int result = num_1;
    if (num_2 > result) result = num_2;
    if (num_3 > result) result = num_3;
    return result;
}

Console.WriteLine("Введите первое число");
int one_number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int two_number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int three_number = Convert.ToInt32(Console.ReadLine());

int max = Max(one_number, two_number, three_number);

Console.WriteLine($"Максимальным из 3-х чисел является число:{max}");
