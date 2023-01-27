//  Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

using static System.Console;
Clear();
Write("Введите 4 целых числа: размерность матрицы (m, n) и диапазон чисел (min, max): ");

int[] intParams=Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ";", ",", ".", "_"},StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrixArray(array);
WriteLine();
WriteLine();
ArrangeMatrixArray();
PrintMatrixArray(array);


void ArrangeMatrixArray()
{
    int fl;
    do
    {
    fl = 0;
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                    fl = 1;
                }
            }
        }
    }
    while (fl == 1);    
}


int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random ran = new Random();
    int[,] resultArray = new int[Convert.ToInt32(rows), Convert.ToInt32(columns)];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = ran.Next(minValue, maxValue+1);
        }
    }
    return resultArray;
}



void PrintMatrixArray(int[,] inArray)
{   
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 6} ");
        }
        WriteLine();
    }
}


