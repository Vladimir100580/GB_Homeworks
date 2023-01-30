using static System.Console;
Clear();
Write("Введите натуральные M и N: ");

int[] intPar=Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ";", ",", ".", "_", "/"},StringSplitOptions.RemoveEmptyEntries), int.Parse);










// 123
/* int GetNumbersSum(int num)
{
    if (num / 10 == 0) return num%10;
    
    else return GetNumbersSum(num/10) + num%10;

} */

/* int result = GetPower(3,5);
Console.WriteLine(result);

int GetPower(int a, int b)
{
    if (b == 1) return a;

    else return GetPower(a, b-1)*a;

} */