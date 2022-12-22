using static System.Console;

WriteLine("Введите первую координату x: ");
int x1 = int.Parse(ReadLine()!);
WriteLine("Введите первую координату y: ");
int y1 = int.Parse(ReadLine()!);
WriteLine("Введите вторую координату x: ");
int x2 = int.Parse(ReadLine()!);
WriteLine("Введите вторую координату y: ");
int y2 = int.Parse(ReadLine()!);
double l = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));

WriteLine($"Длинна отрезка между точками равна {l}");
