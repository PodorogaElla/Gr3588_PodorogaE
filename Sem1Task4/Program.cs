//Считываем данные с консоли
string? Num1Line = Console.ReadLine();
string? Num2Line = Console.ReadLine();
string? Num3Line = Console.ReadLine();

//Проверяем, чтоьы данные были не пустыми
if (Num1Line != null && Num2Line != null && Num3Line != null)
{
//Парсим введенные числа
    int num1 = int.Parse(Num1Line);
    int num2 = int.Parse(Num2Line);
    int num3 = int.Parse(Num3Line);

        //Сравниваем между собой num1 и num2
        if (num1 > num2 )
        {
            if (num1 > num3)
            {
                //Выводим данные в консоль
                Console.WriteLine("max=" + num1);
            }
            else
            {
                Console.WriteLine("max=" + num3);
            }
        }
        else
        {
            //Сравниваем между собой num1 и num3
            if (num2 > num3)
            {
                 //Выводим данные в консоль
                 Console.WriteLine("max="+num2);
            }
            else
            {
                 Console.WriteLine("max="+num3);
            }
    }
}



