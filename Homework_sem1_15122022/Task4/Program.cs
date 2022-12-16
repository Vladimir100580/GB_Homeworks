using static System.Console;

Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);
Write("Введите третье число: ");
int c = int.Parse(ReadLine()!);
int m = a;
if (b > m) {
    m = b;
    }
if (c > m) {
    m = c;
    }
WriteLine($"Максимальное из введенных чисел: {m}");
