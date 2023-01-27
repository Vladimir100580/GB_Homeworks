// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using static System.Console;
Clear();
Write("Введите 4 целых числа: размерность матрицы (m, n) и диапазон чисел (min, max): ");

int[] intParams=Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ";", ",", ".", "_"},StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrixArray(array);
WriteLine();
WriteLine($"Строка(и) с наименьшей суммой: {SearchForAverages(array)}.");



string SearchForAverages(int[,] inArray)         // string - т.к. учитываем случай, когда в матрице найдется более одной строки с мин.суммой.
{                                                // проврить данный случай можно, введя, например: "10 2 3 4"
    string rowNumbers = "";
    int summRow = int.MaxValue;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        if (sum == summRow)                                     
        {
            rowNumbers += ", " + (i + 1).ToString();
        }
        if (sum < summRow)
        {
            rowNumbers = (i + 1).ToString();
            summRow = sum;
        }
    }
    return rowNumbers;
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
            Write($"{inArray[i, j], 5} ");
        }
        WriteLine();
    }
}
