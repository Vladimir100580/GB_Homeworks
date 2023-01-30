// Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

using static System.Console;
Clear();
Write("Введите m и n: ");

int[] intParams=Array.ConvertAll(ReadLine()!.Split(new string[]{" ", ";", ",", ".", "_", "/"},StringSplitOptions.RemoveEmptyEntries), int.Parse);