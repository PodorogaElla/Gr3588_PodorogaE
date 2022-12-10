int num = ReadData ("Введите пятизначное число: ");
bool result = PalinTest(num);
PrintData (result);

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// Метод определяет палиндром
bool PalinTest(int num)
{   
     bool result = false;
     {
        if ((num/10000 == num%10) && (num/1000)%10 == (num/10)%10) result = true;
     }
     return result;
}

//Метод выводит данные пользователю
void PrintData(bool result)
{
   if (result)
   {
    Console.WriteLine("Это число - палиндром");
   }
   else
   {
    Console.WriteLine("Это число - не палиндром");
   }
}