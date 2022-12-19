Console.WriteLine("Введите первое число");
int one_number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число");
int two_number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число");
int three_number = Convert.ToInt32(Console.ReadLine());

int max = one_number;

if (two_number > one_number)
{
    Console.WriteLine("Второе больше");
}
if (three_number > max)
{
    Console.WriteLine("Третье больше");
}