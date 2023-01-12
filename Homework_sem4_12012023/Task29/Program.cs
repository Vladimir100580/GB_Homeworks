// Напишите программу, реализующую метод, который формирует
// массив случайных целых чисел из 8 элементов и выводит их на экран.
// Реализация расширенной версии

using static System.Console;

WriteLine("Введите число элементов в массиве: ");
int n = int.Parse(ReadLine()!);     
WriteLine("Введите нижнюю границу диапазона целых чисел: ");
int n_min = int.Parse(ReadLine()!);
WriteLine("Введите верхнюю границу диапазона целых чисел: ");
int n_max = int.Parse(ReadLine()!);

InitPrintArr(n, n_min, n_max); // т.к. в условии сказано "метод", реализовал и формирование, и вывод - в одном






void InitPrintArr(int n, int n_min, int n_max)
{
    int[] ar = new int[n];
    for (int i=0; i<n; i++)
    {
        ar[i] = new Random().Next(n_min, n_max);
        Write($"{ar[i]} ");
    }
}