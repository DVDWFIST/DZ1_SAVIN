// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Данные вводятся с консоли пользователем

class ElementArray
{

    static void Main(string[] size)
    {
        Console.Write("Введите размерность массива:\t ");
        
        int countArray = int.Parse(Console.ReadLine());
        int[] myArray = new int[countArray];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"\nВведите элемент массива под индексом {i}:\t ");
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nВывод массива: ");

        for(int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + ", ");
        }

    }
}




