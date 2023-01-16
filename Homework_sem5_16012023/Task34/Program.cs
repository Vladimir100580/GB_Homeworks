// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.


using static System.Console;
Clear();
Write("Введите размер массива, мин и макс через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
printArray(array);

int negativeSum = 0;
int positiveSum = 0;

foreach (int a in array)
{
    negativeSum += a < 0 ? a : 0;
    positiveSum += a > 0 ? a : 0;
}

WriteLine($"{negativeSum}   {positiveSum}");

int [] GetArray( int size, int minValue, int maxValue){
    int[] resultArray = new int [size];

    Random ran = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = ran.Next(minValue, maxValue +1);
    }

    return resultArray;
}

void printArray(int[] array){
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}, ");
    }

    WriteLine($"{array[array.Length - 1]}]");
}
