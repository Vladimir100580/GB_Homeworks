using static System.Console;
Clear();
Write("Введите числа через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int n = Quantity(array);
string numtxt = "положительных чисел";         // Создаем "красоту" склонений
if (n%10 == 1 && (n/10)%10 != 1) numtxt = "положительное число";
if (n%10 >= 2 && n%10 <= 4 && (n/10)%10 != 1) numtxt = "положительных числа";

WriteLine($"Вы ввели {Quantity(array)} {numtxt}.");


int Quantity(string[] str)
{
    int s = 0;
    for (int i = 0; i < str.Length; i++)
    {   
        if (double.Parse(str[i]) > 0) s++;
    }
    return s;
}