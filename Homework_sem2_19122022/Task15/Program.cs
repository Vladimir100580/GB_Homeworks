using static System.Console;

Write("Введите номер дня недели: ");
int a = int.Parse(ReadLine()!);
WriteLine(a>0&&a<8?a>5?"Да":"Нет":"Число должно быть целым от 1 до 7");
