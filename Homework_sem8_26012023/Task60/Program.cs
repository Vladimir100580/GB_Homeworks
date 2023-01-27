// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

using static System.Console;
Clear();

int[] arrayNumbers = FormationOfEightNumbers();
printArray(arrayNumbers);
WriteLine();
WriteLine();
WriteLine(MatrixArrayToString(GetMatrixArray(arrayNumbers)));
//int[,,] array1 = GetMatrixArray();







int[] FormationOfEightNumbers()   //формируем массив из восьми неповторяющихся чисел
{
    Random ran = new Random();
    int[] rezarr = new int[] {0, 0, 0, 0, 0, 0, 0, 0};
    for (int i = 0; i < 8; i++)
    {
        bool b = true;
        int r;
        do
        {
            r = ran.Next(10, 100);
            b = rezarr.Contains(r);          // существует ли такое значние в массиве 
        }
        while (b == true);
        rezarr[i] = r;
    }    
    return rezarr;
}


int[,,] GetMatrixArray(int[] inArrN)         // Формируем трехмерную матрицу
{
    int t = 0;
    int[,,] resultArray = new int[2, 2, 2];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)     
        {
            for (int k = 0; k < 2; k++)
            {
                resultArray[i, j, k] = inArrN[t];
                t += 1;
            }
        }
    }      
    return resultArray;
}


string MatrixArrayToString(int[,,] inArrM)         // Переводим матрицу в строку
{
    string st = "";
    for (int i = 0; i < inArrM.GetLength(0); i++)
    {
        for (int j = 0; j < inArrM.GetLength(1); j++)        // конечно, для данной задачи можно было написать двойки
        {
            for (int k = 0; k < inArrM.GetLength(2); k++)
            {
                st += ($"{inArrM[i, j, k]}({i},{j},{k})  ");
            }
        }
    }      
    return st;
}


void printArray(int[] array1){
    Write("[");
    for (int i = 0; i < array1.Length; i++)
    {   
        if (i == 0) {Write($"{array1[i], 7} ");}
        else {Write($"{array1[i], 8} ");}
    }
    Write("]");
}