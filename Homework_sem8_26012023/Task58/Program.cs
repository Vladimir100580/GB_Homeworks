// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

using static System.Console;
Clear();
Write("Введите 4 целых числа: размерность первой матрицы (m1, n1) и размерность второй матрицы (m2, n2): ");

int[] intParams=Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ";", ",", ".", "_", "/"},StringSplitOptions.RemoveEmptyEntries), int.Parse);

if (intParams[1] != intParams[2])
{
    WriteLine("Число столбцов первой матрицы должно совпадать с числом строк второй матрицы");   // В этой задаче диапазон задается в самом скрипте (строка 56)
    return;
}
int[,] array1 = GetMatrixArray(intParams[0], intParams[1]);
int[,] array2 = GetMatrixArray(intParams[2], intParams[3]);

WriteLine("Первая матрица:");
PrintMatrixArray(array1);
WriteLine();
WriteLine("Вторая матрица:");
PrintMatrixArray(array2);
WriteLine();
WriteLine("Результат умножения матриц:");
PrintMatrixArray(MatrixMultiplication(array1, array2));



int[,] MatrixMultiplication(int[,] inArray1, int[,] inArray2)         
{                                                
    int[,] resultArray = new int[inArray1.GetLength(0), inArray2.GetLength(1)];
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)                    
        {
            int sum = 0;
            for (int k = 0; k < inArray2.GetLength(0); k++)                 // ... те самые "строка на столбец"
            {
                sum += inArray1[i, k] * inArray2[k, j];
            }
            resultArray[i, j] = sum;
        }
    }
    return resultArray;
}


int[,] GetMatrixArray(int rows, int columns)
{
    Random ran = new Random();
    int[,] resultArray = new int[Convert.ToInt32(rows), Convert.ToInt32(columns)];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = ran.Next(1, 10);     
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

