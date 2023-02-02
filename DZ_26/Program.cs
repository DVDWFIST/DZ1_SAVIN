// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] GetThreArray(int page, int rows, int colums)
{
    int[,,] myArray = new int[page, rows, colums];
    int count = 11;
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                myArray[i, j, k] += count;
                count ++;
            }
        }
    }
    return myArray;
}

void PrintMatrix(int[,,] myArray)
{
    
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        Console.WriteLine("Page №:" + (i + 1));

        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                Console.Write(myArray[i, j, k] + "->" + (i, j, k) + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}




int[,,] array = GetThreArray(2, 2, 2);
PrintMatrix(array);

