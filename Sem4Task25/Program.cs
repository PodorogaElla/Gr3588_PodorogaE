//запрос данных у пользователя
int a = ReadData("Введите число А:");
int b = ReadData("Введите число B:");
int result = Pow(a,b);
// Метод вычисления результата
int Pow(int a, int b)
{
    int res =1;
    for(int i=1;i<=b;i++)
    {
        res = a * res;
    }
    return res;  
}
// Печать результата
PrintData("А в степени В равно " + result );

int ReadData(string msg)
{
    Console.WriteLine (msg);
    return int.Parse(Console.ReadLine()??"0");
}
void PrintData(string res)
{
    Console.WriteLine(res);
}





