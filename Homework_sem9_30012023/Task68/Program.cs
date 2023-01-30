// Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

using static System.Console;
Clear();
Write("Введите неотрицательные чила M и N: ");

int[] Par=Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ";", ",", ".", "_", "/"},StringSplitOptions.RemoveEmptyEntries), int.Parse);

WriteLine(Akker(Par[0], Par[1]));



int Akker(int M, int N)
    {
        while (M != 0)
        {
            N = (N == 0) ? 1 : Akker(M, N - 1);
            M--;
        }
        return N + 1;
    }