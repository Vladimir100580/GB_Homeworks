using static System.Console;

Write("Введите число:");
bool isParse=int.TryParse(ReadLine(),out int i);
if(!isParse)
{
    WriteLine("Введено не число");
    return;
}
int n = 1;

while (n <= i)
{
    Write(n*n + "  ");
    n ++;
}
