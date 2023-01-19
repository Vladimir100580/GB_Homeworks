using static System.Console;
Clear();
Write("Введите через пробел b1, k1, b2, k2: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine($"{Intersection(array)}");




string Intersection(string[] str)            // Эксперимент с переводом из строки и обратно
{
    double b1 = double.Parse(str[0]);
    double k1 = double.Parse(str[1]);
    double b2 = double.Parse(str[2]);
    double k2 = double.Parse(str[3]);
    if (k1 == k2 ) return "Прямые параллельны.";

    string x = ((b2 - b1) / (k1 - k2)).ToString();
    string y = (k1 * (b2 - b1) / (k1 - k2) + b1).ToString();
    return "Точка пересечения прямых: (" + x + "; " + y + ")";
}