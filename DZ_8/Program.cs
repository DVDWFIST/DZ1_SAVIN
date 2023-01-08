// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

void Palindrom(int numbers)
{
    if (numbers / 10000 == numbers % 10)
    {
        if ((numbers / 1000) % 10 == (numbers % 100) / 10)
            Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палидром");
    }
}

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
Palindrom(number);