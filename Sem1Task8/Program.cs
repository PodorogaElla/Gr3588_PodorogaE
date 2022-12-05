//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтоьы данные были не пустыми
if(inputLine!=null)
{
    //Парсим введенное выражение
    int inputNumber = int.Parse(inputLine);

    //Счетчик цикла для четных чисед
    int index = 2;

    string outLine = string.Empty;

    //Запускаем цикл для четного числа
    while ( index <= inputNumber - 2)
    {
        //Собираем четные числа
        outLine = outLine + index + ",";

        index = index + 2;
    }
    //Добавляем конечное число
    outLine = outLine + index;

    //Выводим данные в консоль
     Console.WriteLine(outLine);
}

