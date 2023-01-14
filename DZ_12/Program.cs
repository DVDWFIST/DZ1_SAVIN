// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}

int ReadNumber(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}


int numSum = ReadNumber("Введите число");
if (numSum > 0)
{
    int summa = SumNumber(numSum);
    Console.WriteLine($"Сумма цифр числа {numSum} равна {SumNumber(numSum)}!");
}
else
{
    Console.WriteLine("Вы ввели неверное число!");
}