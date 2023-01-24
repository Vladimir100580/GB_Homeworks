// Напишите программу реализующую метод, 
// который возвращает массив размером m×n, заполненный случайными вещественными числами.

using static System.Console;
Clear();
Write("Введите 5 чисел: размерность матрицы (m, n), диапозон значений (min, max) и точность чисел (количество знаков после запятой) через пробел: ");

double[] doubParams=Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ";"},StringSplitOptions.RemoveEmptyEntries), double.Parse);

double[,] array = GetMatrixArray(doubParams[0], doubParams[1], doubParams[2], doubParams[3], doubParams[4]);

PrintMatrixArray(array);




double[,] GetMatrixArray(double rows, double columns, double minValue, double maxValue, double accuracy)
{
    Random ran = new Random();
    double[,] resultArray = new double[Convert.ToInt32(rows), Convert.ToInt32(columns)];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = Math.Round(minValue + (maxValue - minValue) * ran.NextDouble(), Convert.ToInt32(accuracy));
        }
    }
    return resultArray;
}


void PrintMatrixArray(double[,] inArray)
{   
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j], 10} ");
        }
        WriteLine();
    }
}