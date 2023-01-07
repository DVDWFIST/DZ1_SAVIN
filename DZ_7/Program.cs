// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int digitIndex = 2;
if (number >= 100)
{
    int digit = number.ToString()[digitIndex] - '0';
    Console.WriteLine(digit);
}

else
{
    Console.WriteLine("Такого числа нет");
}


