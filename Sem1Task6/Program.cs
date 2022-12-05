//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтоьы данные были не пустыми
if(inputLine!=null)
{
    //Парсим введенное выражение
    int evenNumber = int.Parse(inputLine);

    //Проверяем переменную на четность
    if ((evenNumber % 2) == 0) 
    {
        //Выводим данные в консоль
        Console.WriteLine("Четное!");
    }
    else
    {
        Console.WriteLine("Не четное!");
    }
}


