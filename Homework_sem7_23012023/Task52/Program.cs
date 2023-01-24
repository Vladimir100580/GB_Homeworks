// Напишите программу реализующую методы, формирования двумерного массива
// и массива средних арифметических значений каждого столбца.

using static System.Console;
Clear();
Write("Введите 4 целых числа: размерность матрицы (m, n) и диапазон чисел (min, max): ");

int[] intParams=Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ";", ",", ".", "_"},StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrixArray(array);

printArray(SearchForAverages(array));





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


double[] SearchForAverages(int[,] inArray)
{   
    double[] avarArray = new double[inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        avarArray[j] = sum/inArray.GetLength(0); 
        //Write($"{avarArray[j]} , {sum}, {inArray.GetLength(0)}    ");
    }
    return avarArray;
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

void printArray(double[] array1){
    Write("[");
    for (int i = 0; i < array1.Length - 1; i++)
    {
        Write($"{array1[i]}, ");
    }

    WriteLine($"{array1[array1.Length - 1]}]");
}