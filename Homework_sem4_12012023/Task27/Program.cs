// Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;

WriteLine("Введите целое число: ");
int A = int.Parse(ReadLine()!);      // подразумеваем, что вводится целое число

int sum = SumDigits(A);
WriteLine($"Сумма цифр в числе {A} равна {sum}");










int SumDigits(int A)
{
    if (A < 0) A *= -1;
    int s = 0;
    while (A > 0)
    {
        s += A%10;
        A /= 10;
    }
    return s;
}
