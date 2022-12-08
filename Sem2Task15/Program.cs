//Считываем данные с консоли,парсим, проверяем на наличие значения
int dayOfweek = int.Parse(Console.ReadLine()??"0");

//Проверяем переменную на количество дней в неделе
if (dayOfweek>0 && dayOfweek<8)
{
    //Определяем рабочий или выходной день
    if (dayOfweek>5)
    {
    //Выводим данные в консоль
    Console.WriteLine( "Ура! Выходной!!!" );
    }
    else
    {
    Console.WriteLine("На работу! На работу!");
    }
}
else
    {
    Console.WriteLine("Такого дня не существует...");
    }
