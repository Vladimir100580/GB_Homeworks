// Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.

using static System.Console;
Clear();
Write("Введите натуральное N: ");
int a = int.Parse(ReadLine()!);

string result=GetNumbers(a);
WriteLine(result);


string GetNumbers(int num)
{
    return (num == 1) ? num.ToString() + "." : $"{num}, {GetNumbers(num-1)}";
}

