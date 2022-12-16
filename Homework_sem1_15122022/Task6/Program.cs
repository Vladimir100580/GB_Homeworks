using static System.Console;

Write("Введите число: ");
int a = int.Parse(ReadLine()!);
if (a % 2 == 0) {
    WriteLine($"Число {a} является четным.");
    }
else {
    WriteLine($"Число {a} является НЕчетным.");
    }    
