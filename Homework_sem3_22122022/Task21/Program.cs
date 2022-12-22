using static System.Console;

WriteLine("Введите абсциссу первой точки x1: ");
int x1 = int.Parse(ReadLine()!);
WriteLine("Введите ординату первой точки y1: ");
int y1 = int.Parse(ReadLine()!);
WriteLine("Введите аппликату первой точки z1: ");
int z1 = int.Parse(ReadLine()!);

WriteLine("Введите абсциссу второй точки x2: ");
int x2 = int.Parse(ReadLine()!);
WriteLine("Введите ординату второй точки y2: ");
int y2 = int.Parse(ReadLine()!);
WriteLine("Введите аппликату второй точки z2: ");
int z2 = int.Parse(ReadLine()!);

double l = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));

WriteLine($"Расстояние между точками равно {l:f2}");
