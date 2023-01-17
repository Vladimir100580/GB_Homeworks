// Напишите программу реализующую методы формирования массива, заполненного 
// случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов

using static System.Console;
Clear();

Write("Введите размер массива, точность элементов(знаков после запятой), мин и макс через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), double.Parse(parameters[2]), double.Parse(parameters[3]));

printArray(array);

WriteLine($"Разность между максимальным и минимальным элементами: {Math.Round(Srarch(array), int.Parse(parameters[1]))}");
    // здесь тоже округляем, т.к. в некоторых случаях, при вычислении разности двух вещественных чисел (строка 30), в высоких разрядах выдает погрешность                            




double Srarch(double[] array)
{
    double max = array[0];
    double min = array[0];
    foreach (double a in array)
    {
        if (a > max) max = a;
        if (a < min) min = a;
    }
    WriteLine($"Макс: {max}; Мин: {min}");
    return(max - min);
} 


double[] GetArray(int size, int accuracy, double minValue, double maxValue)
{
    double[] resultArray = new double[size];
    Random ran = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = Math.Round(minValue + (maxValue - minValue) * ran.NextDouble(), accuracy);
    }
    return resultArray;
}


void printArray(double[] array){
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Write($"{array[i]}; ");
    }
    WriteLine($"{array[array.Length - 1]}]");
}
