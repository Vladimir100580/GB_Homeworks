using static System.Console;

Write("Введите натуральное число:");
bool isParse=double.TryParse(ReadLine(),out double i);
if(!isParse)
{
    WriteLine("Введено не число");
    return;
}
if(i != Math.Round(i,0) || i < 1)
{
    WriteLine("Введено НЕ натуральное число");
    return;
}
int n = 1;

while (n <= i)
{
    Write(Math.Pow(n,3));
    if(n!=i) Write(", ");   //делаем красоту со знаками между числами и в конце ряда
    else Write(".");
    n += 1;
}
