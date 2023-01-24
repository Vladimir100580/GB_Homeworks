// Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, 
//и возвращающий значение этого элемента или же указание, что такого элемента нет.

using static System.Console;
Clear();
Write("Введите 4 целых, неотрицательных числа: размерность матрицы (m, n) и позицию (координаты) элемента: ");

int[] intParams=Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ";", ",", ".", "_"},StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetMatrixArray(intParams[0], intParams[1]);

PrintMatrixArray(array);

WriteLine();
WriteLine(intParams[2]<intParams[0] && intParams[3]<intParams[1] ? $"{array[intParams[2],intParams[3]]}" : "такого элемента нет в массиве");



int[,] GetMatrixArray(int rows, int columns)
{
    Random ran = new Random();
    int[,] resultArray = new int[Convert.ToInt32(rows), Convert.ToInt32(columns)];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = ran.Next(1, 101);
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
            Write($"{inArray[i, j], 4} ");
        }
        WriteLine();
    }
}