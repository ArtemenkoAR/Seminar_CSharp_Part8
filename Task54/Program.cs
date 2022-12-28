// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] Fill(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void Print(int[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            Console.Write($"{arr2[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Decrease(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                int max = array[i, k];
                if (array[i, k + 1] > max )
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}

int[,] array = Fill(3, 4, -5, 5);
Print(array);
Console.WriteLine();
Decrease(array);
Print(array);
