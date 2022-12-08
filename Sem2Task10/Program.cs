//Считываем данные с консоли,парсим, проверяем на наличие значения.
int number1 = int.Parse(Console.ReadLine()??"0");

//Проверяем переменную на трехзначность
if (number1<1000 && number1>99)
{
    //Выделяем вторую цифру
    int result = (number1/10)%10;

    //Выводим данные в консоль
    Console.WriteLine( "Вторая цифра числа" + result );
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
