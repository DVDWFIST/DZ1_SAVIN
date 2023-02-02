// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void PrintMatrix(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write("{0,3} ", myArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetSpire(int size)
{
    int[,] matrix = new int[size, size];
    int number = 1;
    for (int i = 0; i < size / 2; i++)
    {
        for (int j = i; j < size - i; j++) matrix[i,j] = number++;
        for (int k = i + 1; k < size - i; k++) matrix[k,size - 1 -i] = number++;
        for (int j = size - i - 2; j >= i; j--) matrix[size - 1 - i, j] = number++;
        for (int k = size - 2 - i; k > i; k--) matrix[k,i] = number++;
    }
    return matrix; 
}



int[,]matrix = GetSpire(4);
PrintMatrix(matrix);