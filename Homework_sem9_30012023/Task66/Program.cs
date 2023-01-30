// Напишите программу, которая реализует рекурсивный метод нахождения
// суммы натуральных элементов в промежутке от M до N.

using static System.Console;
Clear();
Write("Введите целые M и N: ");

int[] Par=Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ";", ",", ".", "_", "/"},StringSplitOptions.RemoveEmptyEntries), int.Parse);

WriteLine(GetSumm(Par[0], Par[1]));


int GetSumm(int M, int N)
{
    return (M == N) ? M : (M < N) ? GetSumm(M, N - 1) + N : GetSumm(M, N + 1) + N;
}