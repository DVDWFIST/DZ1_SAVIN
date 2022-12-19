Console.WriteLine("Введите первое число");
int one_number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int two_number = Convert.ToInt32(Console.ReadLine());

if (one_number>two_number)
{
    Console.WriteLine("Первое больше");
}

else if(two_number>one_number)
{
    Console.WriteLine("Второе больше");
} 

else
    Console.WriteLine("Они равны");