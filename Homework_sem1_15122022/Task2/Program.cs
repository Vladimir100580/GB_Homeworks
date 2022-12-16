using static System.Console;

Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);
if (a > b) {
    WriteLine($"Большее число: {a}, меньшее число: {b}");
    }
else {
    WriteLine($"Большее число: {b}, меньшее число: {a}");
    }
    