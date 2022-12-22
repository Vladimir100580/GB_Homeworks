using static System.Console;

Write("Введите пятизначное натуральное число:");
bool isParse=double.TryParse(ReadLine(),out double i);
if(!isParse)
{
    WriteLine("Введено не число");
    return;
}
if(i != Math.Round(i,0)) 
{
    WriteLine("Число должно быть целым");
    return;
}
if(i <= 10000 || i > 99999)
{
    WriteLine("Число должно быть пятизначным и положительным");
    return;
}
int ii = Convert.ToInt32(i);          //Пришлось погуглить, дабы избежать ошибки несоответствия типов 
int digit_1 = (ii - ii%10000)/10000;
ii = ii - digit_1 * 10000;
int digit_2 = (ii - ii%1000)/1000;
ii = ii - digit_2 * 1000;
int digit_3 = (ii - ii%100)/100;
ii = ii - digit_3 * 100;
int digit_4 = (ii - ii%10)/10;
int digit_5 = ii%10;

if(digit_1 == digit_5 && digit_2 == digit_4)
{
    WriteLine("Да");
}
else
{
    WriteLine("Нет");
}
