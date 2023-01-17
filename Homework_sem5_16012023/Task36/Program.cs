using static System.Console;
Clear();
Write("Введите размер массива, мин и макс через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));
printArray(array);

int negativeSum = 0;
int positiveSum = 0;
