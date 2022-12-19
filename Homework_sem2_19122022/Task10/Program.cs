using static System.Console;

Write("Введите трехзначное число: ");
int a = int.Parse(ReadLine()!);
WriteLine(((a-a%10)/10)%10); //((a-a%10)/10) - целочисленно делим a на 10
