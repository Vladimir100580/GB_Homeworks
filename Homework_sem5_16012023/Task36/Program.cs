// Напишите программу реализующую методы формирования массива, заполненного случайными числами
// и подсчета суммы элементов, стоящих на нечётных позициях.



using static System.Console;
Clear();
Write("Введите размер массива, мин и макс через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));

printArray(array);
WriteLine($"Сумма элементов, стоящих на нечётных позициях: {Sum(array)}");




int Sum(int[] array)
{
    int s = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        s += array[i];
    }
    return s;
}


int[] GetArray( int size, int minValue, int maxValue)
{
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
