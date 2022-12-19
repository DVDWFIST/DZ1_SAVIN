Console.WriteLine("Введите число");
int one_number = Convert.ToInt32(Console.ReadLine());

for (int count = 0; count<= one_number; count++ )
    if (count % 2 == 0)
    Console.WriteLine(count);