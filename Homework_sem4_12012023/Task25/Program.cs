
// Напишите программу, реализующую метод,который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B с использованием цикла.

using static System.Console;

WriteLine("Введите основание А: ");
double A = double.Parse(ReadLine()!);      // в условии не указана "натуральность" числа A, поэтому double
WriteLine("Введите показатель степени B: ");
int B = int.Parse(ReadLine()!);

double p1 = PowAB(A, B);
WriteLine($"A^B = {p1}");






double PowAB(double A, int B)
{
    double p = 1;
    for (int i=0; i<B; i++)
    {
        p *= A;
    }
    return p;
}
