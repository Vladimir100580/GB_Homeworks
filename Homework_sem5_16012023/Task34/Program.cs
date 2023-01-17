// Напишите программу реализующую методы формирования массива,
// заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



using static System.Console;
Clear();
WriteLine("Введите число элементов в массиве: ");

int n = int.Parse(ReadLine()!);
int[] array = GetArray(n);

printArray(array);
int m = FindEvenNumb(array);
WriteLine($"Четных чисел в массиве: {m}");



int FindEvenNumb(int[] array)
{
    int quantity = 0;
    foreach (int a in array)
    {
        if (a%2 == 0) quantity++;
    }
    return quantity;
}


int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random ran = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = ran.Next(100, 999);
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
