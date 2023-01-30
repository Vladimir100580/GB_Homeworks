﻿// Определить можно ли составить вторую строку из первой.

using static System.Console;
Clear();

Write("Введите первую строку (из которой будем составлять вторую): ");
string st1 = ReadLine();

Write("Введите вторую строку: ");
string st2 = ReadLine();

WriteLine($"{DetExist(CreatArray(st1.ToLower()), st2.ToLower())} составить из букв строки '{st1}' строку '{st2}'.");



int[] CreatArray(string st1)               // Беспощадное используем память! Если решать задачу для Латиницы, можно ограничится меньшим массивом (до 122)
{
    int[] arr = new int[1100];             //Создаем массив, каждый адресс которого соответствует значению символа в ascii
    foreach (int i in st1)   {arr[i]++;}   //с каждым появлением символа, добавляем по текущему адресу единицу.
    arr[32] = int.MaxValue;                // Пробелы - не в счет. По умолчанию, делаем ОООчень много.                                     
    return arr;
}


string DetExist(int[] inArr, string st2)
{            
    foreach (int i in st2)   
    {
        inArr[i]--;                                 //пробегаем по второй строке, вычитая по единице в соответсвующих ячейках
        if (inArr[i] < 0) {return "Невозможно";}    //ушли в минус по какому-либо элементу, значит - невозможно
    }   
    return "Возможно";
}
