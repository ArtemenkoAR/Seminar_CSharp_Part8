// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов

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

void Print1(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[] arr3(int[,] arr1)
{
    int[] FinalArray = new int[arr1.GetLength(0)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        int SumRows = 0;
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            SumRows = SumRows + arr1[i, j];
        }
        FinalArray[i] = SumRows;
    }
    return FinalArray;
}

void Min(int[] arr3)
{
    int min = arr3[0];
    int index = 0;

    for (int i = 1; i < arr3.Length; i++)

        if (min > arr3[i])
        {
            min = arr3[i];

            index = i;
        }
    Console.WriteLine($"Строка с наименьшей суммой элементов = {index + 1}");
}

int[,] array = Fill(3, 3, 1, 7);
Print(array);
Console.WriteLine();
int[] Array = arr3(array);
Print1(Array);
Console.WriteLine();
Min(Array);
