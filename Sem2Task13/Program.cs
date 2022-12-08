//Считываем данные с консоли,парсим, проверяем на наличие значения.
int number1 = int.Parse(Console.ReadLine()??"0");

//Проверяем переменную на трехзначность
if (number1>99)
{
    //Выделяем третью цифру
    char[] digits = number1.ToString().ToCharArray();

    //Выводим данные в консоль
    Console.WriteLine("Третья цифра"  + digits[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}