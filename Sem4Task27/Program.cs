int number = ReadData("Введите число А:");
int sum = SumDigit1(number);
PrintData("Сумма цифр в числе равна " + sum);
// Программа считывает число:
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Программа выдает число:
void PrintData(string res)
{
    Console.WriteLine(res);
}
// Метод вычисления:
int SumDigit1(int num)
{    
    int res = 0;
    while(num>0)
    {
        res+=num%10;
        num=num/10;
    }
    return res;
}
// Подсчет затраченного на вычисление времени:
DateTime d1 = DateTime.Now;
Console.WriteLine(DateTime.Now - d1);



