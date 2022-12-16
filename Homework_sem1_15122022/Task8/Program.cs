using static System.Console;

Write("Введите натуральное число: ");
int a = int.Parse(ReadLine()!);
int half_a = (a - a % 2) / 2; //Появилось откровение сократить количество итераций вдвое 
string st = "";
if (a == 1) {st = "отсутствуют";}
int i = 1;
WriteLine($"Четные числа от 1 до {a}: "); //'1' - не является четным, но формулирую, как в условии задачи
while (i <= half_a) {
    Write($"{i*2} ");
    i++;
    }
Write(st);   
